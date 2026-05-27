# Python Tips
Python is a popular, open-source, general purpose programming language which shines in areas like data analysis and machine learning due to its easy syntax and huge community. This section aims to provide some tips on how Python can be used in your research.

## uv
[uv](https://docs.astral.sh/uv/) is a Python package and project manager, with a lot of functionality out of the box. Its main strengh is the ability to create and manage projects with isolated virtual environments in which the versions of the packages used are automatically stored in 2 files (`pyproject.toml` and `uv.lock`) so that it's really easy to share and deploy the project. All of this can be done with only 4 commands (although `uv` provides a lot more).

> [!IMPORTANT]
> Follow the instructions on the official [documentation](https://docs.astral.sh/uv/getting-started/installation/) to install `uv`.

With that said, let's create our first Python project with `uv`.
1. Create the `uv` project and go to the project directory.
    ```
    uv init --package project_name
    cd project_name
    ```
2. Add the necessary packages to your project. For example, if we need `numpy`, we shall run:
    ```
    uv add numpy
    ```
3. Run your script.
    ```
    uv run [script_name].py
    ```

With these 3 steps, one can already start developing and running a Python project. If now, we need to install the project in a different machine, we can simply follow the steps below.
1. Download or clone the repository.
    > [!NOTE]
    > This step assumes that the project's repository is hosted on a platform like GitHub.
    >
    > Visit the tutorial on [Version Control](./VersionControl.md) to learn how to work with repositories.
2. Inside the project's directory, execute the following command to create the virtual environment and install the necessary packages (with the correct versions).
    ```
    uv sync
    ```
3. Run the main project script.
    ```
    uv run [script_name].py
    ```

## Sgen
[Sgen](https://bonsai-rx.org/sgen/index.html) is a code generation tool for Bonsai that generates custom operators for new data types from JSON Schemas. This tool is very helpful to define the objects containing configuration parameters that can be modified by the user in a YAML or JSON file.

The goal for this section is to go over a possible pipeline of how to define a configuration class in Python (with `pydantic`), generate the JSON schema and the Bonsai nodes with `Sgen`, create the configuration file, load it in Bonsai and save the object in a new file. Click [here](https://github.com/ZegCricket/sgen-example) to go to the repository containing all of the code used in this tutorial.

> [!WARNING]
> This tutorial requires that the [.NET SDK](https://dotnet.microsoft.com/en-us/download) to be installed.

> [!NOTE]
> For a more in-depth understanding of `Sgen`, read the official [documentation](https://bonsai-rx.org/sgen/index.html).

### Creating the project
Firstly, let's create our project, organized according to the [Project Directory Structure](ProjectDirectoryStructure.md) section. Let's create the necessary files and directories:
1. Create the [Bonsai environment](https://bonsai-rx.org/docs/articles/environments.html) inside the `./bonsai` directory and install the `Bonsai.System` and `Newtonsoft.Json` packages.
    > [!NOTE]
    > Click [here](https://bonsai-rx.org/docs/articles/packages.html) to learn how to install packages in Bonsai.
    >
    > To find the `Newtonsoft.Json` package, click on `Show advanced`.
2. Initialize the Python environment with [uv](#uv) inside the `./python` directory and install the `pydantic` package.
    ```
    uv init --package python
    uv add pydantic
    ```
3. Install `Bonsai.Sgen`.
    ```
    dotnet new tool-manifest
    dotnet tool install --local Bonsai.Sgen
    ```
4. Create the directories `./src` (where our Bonsai workflow, extensions and schemas will live) and `./config` (which will have the configuration file of the workflow).
5. Inside the `./src` directory, create the `Extensions.csproj` file with the following content:
    ```
    <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFramework>net472</TargetFramework>
    </PropertyGroup>

    <ItemGroup>
        <PackageReference Include="Bonsai.Core" Version="2.9.0" />
        <PackageReference Include="YamlDotNet" Version="16.3.0" />
        <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
    </ItemGroup>

    </Project>
    ```

### Define the configuration data type
In this subsection, we will define in Python the data structure that we will want to specify in our configuration file and that we want to read inside Bonsai. From the Python class defined, we'll then generate the JSON schema and the C# extensions that will be used inside Bonsai.

Before creating the Python class that defines our configuration, we will create a `_utils.py` file inside our Python module (i.e. `./python/src/python`) with the following code:
```
import inspect
import json
from enum import Enum
from os import PathLike
from subprocess import CompletedProcess, run
from typing import Any, List, Optional, Type

from pydantic import BaseModel, PydanticInvalidForJsonSchema
from pydantic.json_schema import (
    GenerateJsonSchema,
    JsonSchemaMode,
    JsonSchemaValue,
    _deduplicate_schemas,
    models_json_schema,
)
from pydantic_core import PydanticOmit, core_schema, to_jsonable_python


class CustomGenerateJsonSchema(GenerateJsonSchema):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.nullable_as_oneof = kwargs.get("nullable_as_oneof", True)
        self.unions_as_oneof = kwargs.get("unions_as_oneof", True)
        self.render_x_enum_names = kwargs.get("render_x_enum_names", True)

    def nullable_schema(self, schema: core_schema.NullableSchema) -> JsonSchemaValue:
        null_schema = {"type": "null"}
        inner_json_schema = self.generate_inner(schema["schema"])

        if inner_json_schema == null_schema:
            return null_schema
        else:
            if self.nullable_as_oneof:
                return self.get_flattened_oneof([inner_json_schema, null_schema])
            else:
                return super().get_flattened_anyof([inner_json_schema, null_schema])

    def get_flattened_oneof(self, schemas: list[JsonSchemaValue]) -> JsonSchemaValue:
        members = []
        for schema in schemas:
            if len(schema) == 1 and "oneOf" in schema:
                members.extend(schema["oneOf"])
            else:
                members.append(schema)
        members = _deduplicate_schemas(members)
        if len(members) == 1:
            return members[0]
        return {"oneOf": members}

    def enum_schema(self, schema: core_schema.EnumSchema) -> JsonSchemaValue:
        """Generates a JSON schema that matches an Enum value.

        Args:
            schema: The core schema.

        Returns:
            The generated JSON schema.
        """
        enum_type = schema["cls"]
        description = (
            None if not enum_type.__doc__ else inspect.cleandoc(enum_type.__doc__)
        )
        if (
            description == "An enumeration."
        ):  # This is the default value provided by enum.EnumMeta.__new__; don't use it
            description = None
        result: dict[str, Any] = {
            "title": enum_type.__name__,
            "description": description,
        }
        result = {k: v for k, v in result.items() if v is not None}

        expected = [to_jsonable_python(v.value) for v in schema["members"]]

        result["enum"] = expected
        if len(expected) == 1:
            result["const"] = expected[0]

        types = {type(e) for e in expected}
        if isinstance(enum_type, str) or types == {str}:
            result["type"] = "string"
        elif isinstance(enum_type, int) or types == {int}:
            result["type"] = "integer"
        elif isinstance(enum_type, float) or types == {float}:
            result["type"] = "numeric"
        elif types == {bool}:
            result["type"] = "boolean"
        elif types == {list}:
            result["type"] = "array"

        _type = result.get("type", None)
        if (self.render_x_enum_names) and (_type != "string"):
            result["x-enumNames"] = [
                screaming_snake_case_to_pascal_case(v.name) for v in schema["members"]
            ]

        return result

    def literal_schema(self, schema: core_schema.LiteralSchema) -> JsonSchemaValue:
        """Generates a JSON schema that matches a literal value.

        Args:
            schema: The core schema.

        Returns:
            The generated JSON schema.
        """
        expected = [v.value if isinstance(v, Enum) else v for v in schema["expected"]]
        # jsonify the expected values
        expected = [to_jsonable_python(v) for v in expected]

        types = {type(e) for e in expected}

        if len(expected) == 1:
            if isinstance(expected[0], str):
                return {"const": expected[0], "type": "string"}
            elif isinstance(expected[0], int):
                return {"const": expected[0], "type": "integer"}
            elif isinstance(expected[0], float):
                return {"const": expected[0], "type": "number"}
            elif isinstance(expected[0], bool):
                return {"const": expected[0], "type": "boolean"}
            elif isinstance(expected[0], list):
                return {"const": expected[0], "type": "array"}
            elif expected[0] is None:
                return {"const": expected[0], "type": "null"}
            else:
                return {"const": expected[0]}

        if types == {str}:
            return {"enum": expected, "type": "string"}
        elif types == {int}:
            return {"enum": expected, "type": "integer"}
        elif types == {float}:
            return {"enum": expected, "type": "number"}
        elif types == {bool}:
            return {"enum": expected, "type": "boolean"}
        elif types == {list}:
            return {"enum": expected, "type": "array"}
        # there is not None case because if it's mixed it hits the final `else`
        # if it's a single Literal[None] then it becomes a `const` schema above
        else:
            return {"enum": expected}

    def union_schema(self, schema: core_schema.UnionSchema) -> JsonSchemaValue:
        """Generates a JSON schema that matches a schema that allows values matching any of the given schemas.

        Args:
            schema: The core schema.

        Returns:
            The generated JSON schema.
        """
        generated: list[JsonSchemaValue] = []

        choices = schema["choices"]
        for choice in choices:
            # choice will be a tuple if an explicit label was provided
            choice_schema = choice[0] if isinstance(choice, tuple) else choice
            try:
                generated.append(self.generate_inner(choice_schema))
            except PydanticOmit:
                continue
            except PydanticInvalidForJsonSchema as exc:
                self.emit_warning("skipped-choice", exc.message)
        if len(generated) == 1:
            return generated[0]
        if self.unions_as_oneof is True:
            return self.get_flattened_oneof(generated)
        else:
            return self.get_flattened_anyof(generated)


def export_schema(
    model: BaseModel,
    schema_generator: Type[GenerateJsonSchema] = CustomGenerateJsonSchema,
    mode: JsonSchemaMode = "serialization",
    def_keyword: str = "definitions",
    models_title: Optional[str] = None,
):
    """Export the schema of a model to a json file"""
    if not isinstance(model, list):
        _model = model.model_json_schema(schema_generator=schema_generator, mode=mode)
    else:
        models = [(m, mode) for m in model]
        _, _model = models_json_schema(
            models, schema_generator=schema_generator, title=models_title
        )
    json_model = json.dumps(_model, indent=2)
    json_model = json_model.replace("$defs", def_keyword)
    return json_model


def screaming_snake_case_to_pascal_case(value: str) -> str:
    words = value.split("_")
    return "".join(word.capitalize() for word in words)


class BonsaiSgenSerializers(Enum):
    NONE = "None"
    JSON = "json"
    YAML = "yaml"


def bonsai_sgen(
    schema_path: PathLike,
    output_path: PathLike,
    namespace: str = "DataSchema",
    root_element: Optional[str] = None,
    serializer: Optional[List[BonsaiSgenSerializers]] = None,
    executable: PathLike | str = "dotnet tool run bonsai.sgen",
) -> CompletedProcess:
    """Runs Bonsai.SGen to generate a Bonsai-compatible schema from a json-schema model
    For more information run `bonsai.sgen --help` in the command line.

    Returns:
        CompletedProcess: The result of running the command.
    Args:
        schema_path (PathLike): Target Json Schema file
        output_path (PathLike): Specifies the name of the
          file containing the generated code.
        namespace (Optional[str], optional): Specifies the
          namespace to use for all generated serialization
          classes. Defaults to DataSchema.
        root_element (Optional[str], optional):  Specifies the
          name of the class used to represent the schema root element.
          If None, it will use the json schema root element. Defaults to None.
        serializer (Optional[List[BonsaiSgenSerializers]], optional):
          Specifies the serializer data annotations to include in the generated classes.
          Defaults to None.
    """

    if serializer is None:
        serializer = [BonsaiSgenSerializers.JSON]

    cmd_string = f'{executable} "{schema_path}" --output "{output_path}"'
    cmd_string += "" if namespace is None else f" --namespace {namespace}"
    cmd_string += "" if root_element is None else f" --root {root_element}"

    if len(serializer) == 0 or BonsaiSgenSerializers.NONE in serializer:
        cmd_string += " --serializer none"
    else:
        cmd_string += " --serializer"
        cmd_string += " ".join([f" {sr.value}" for sr in serializer])
    return run(cmd_string, shell=True, check=True)


def pascal_to_snake_case(value: str) -> str:
    result = ""
    for i, char in enumerate(value):
        if char.isupper():
            if i != 0:
                result += "_"
            result += char.lower()
        else:
            result += char
    return result
```
This code is adapted from [this](https://github.com/bonsai-rx/conference/blob/2024/_topics/08-reproducible-research-practices/src/python/_utils.py) workshop given by Bruno Cruz. To know what this code does is out of the scope of this tutorial, but we will make use of its functions when we define our configuration class.

For our task, we will want to load a configuration file that contains the following information:
- Animal ID
- Batch ID
- Device serial port (e.g. `COM3`)
- Session-related parameters
    - Session number
    - Session type (which can be `Training` or `SteadyState`)
    - Session duration

To define this structure, we'll create a `config.py` file inside our model and start by creating the `Config` class:
```
from pydantic import BaseModel, Field
from pydantic.types import StringConstraints
from typing_extensions import Annotated


class Config(BaseModel):
    animal: str = Field(description="The ID of the animal.")
    batch: str = Field(description="The batch to which the animal belongs to.")
    session: Session = Field(description="Session-related parameters.")
    device_port: Annotated[str, StringConstraints(pattern=r"^COM\d+$")] = Field(
        description="The device serial port."
    )
```
In order to leverage `pydantic`, we make our `Config` class inherit from `BaseModel`. Every parameter is defined by using the same motif:
```
parameter_name: type = Field(description="some description")
```
> [!TIP]
> For numeric types (e.g. int or float), we can constrain the interval of valid values by specifying values for the following parameters of `Field`: `ge` (greater than or equal to), `gt` (greater than), `le` (less than or equal to), `lt` (less than).
>
> As an example, if we want a parameter to have a value that belongs to the interval $[0, 1[$, we can define it as follows:
> ```
> parameter: float = Field(description="some description", ge=0, lt=1)
> ```

The first two parameters are pretty straight forward, since they can take any string value. The `session` parameter is of type `Session`, which we'll create later. The `device_port` parameter is a string parameter that must be formatted as `COMx` in which `x` is a group of digits (in order to represent a serial port in Windows). That's what `Annotated[str, StringConstraints(pattern=r"^COM\d+$")]` means.
> [!NOTE]
> We can modify the formatting of the string by modifying the [regex](https://en.wikipedia.org/wiki/Regular_expression) pattern from `^COM\d+$` to anything else.

Let's now define the `Session` class **above** the `Config` class.
```
class Session(BaseModel):
    number: int = Field(description="The number of the current session", gt=0)
    type: SessionType = Field(
        description="The session type.", default=SessionType.STEADY_STATE
    )
    duration: timedelta = Field(description="The session duration.")
```
As before, `Session` inherits from `BaseModel`. The `number` parameter is pretty straight forward, we just want to make sure that the session number is positive. The `type` parameter is of type `SessionType`, which will be a `StrEnum` that we'll define later. Note that we assigned a default value.
> [!NOTE]
> Assigning default values to parameters can be useful for parameters that rarely need to be configured, so that they can be ommited in the configuration file.

The `duration` parameter is of the type `timedelta` so that in the configuration is defined as `hh:mm:ss` (e.g. `02:00:00` in case we want a 2-hour session).

> [!CAUTION]
> Don't forget to import `timedelta`!
>
> ```
> from datetime import timedelta
> ```

Let's now define the `SessionType` enum to finish the definition of configuration. We want to express the idea that only a discrete set of values is available and, at the same time, we want the users to input explicitly the name of the session type instead of having to know an hypothetical code that corresponds to a specific type (e.g. `Training` = 0, `SteadyState` = 1). This problem can be solved by defining `SessionType` as a `StrEnum`, as mentioned earlier. 
```
class SessionType(StrEnum):
    TRAINING = "Training"
    STEADY_STATE = "SteadyState"
```
> [!CAUTION]
> Don't forget to import `StrEnum`!
>
> ```
> from enum import StrEnum
> ```

An additional advantage to this solution is the reusability of this data structure in case it's needed in a different Python script (e.g. during data analysis).

Finally, after fully defining the `Config` class, both the C# extensions and the JSON schema must be generated. The function below does exactly that.
```
def main() -> None:
    json_schema = export_schema(Config)
    schema_name = Config.__name__
    _dashed = pascal_to_snake_case(schema_name).replace("_", "-")
    schema_path = Path(rf"../src/config/schemas/{_dashed}-schema.json")
    os.makedirs(schema_path.parent, exist_ok=True)
    with open(schema_path, "w", encoding="utf-8") as f:
        f.write(json_schema)

    bonsai_sgen(
        schema_path=schema_path,
        output_path=Path(rf"../src/Extensions/{schema_name}.cs"),
        namespace=schema_name,
        serializer=[BonsaiSgenSerializers.JSON, BonsaiSgenSerializers.YAML],
    )

if __name__ == "__main__":
    main()
```
> [!CAUTION]
> Import the necessary dependencies!
>
> ```
> import os
> from pathlib import Path
> from sgen._utils import (
>     BonsaiSgenSerializers,
>     bonsai_sgen,
>     export_schema,
>     pascal_to_snake_case,
> )
> ```

Run the script from the `./python` directory.
```
uv run ./src/python/config.py
```

### Configure the session and launch the task
After generating the desired files, it's now possible to create a configuration file and open it in a Bonsai workflow. Let's first create the `config.yml` file inside the `./config` directory.
```
# yaml-language-server: $schema=../src/config/schemas/config-schema.json
animal: animal_name
batch: batch_name
session:
  number: 1
  type: SteadyState
  duration: 00:01:00
device_port: COM3
```
The first thing to notice is that the file is easy to read, even for new users, and that the parameters resemble what we defined in the previous subsection.

The next thing that can caught one's attention is the first line of the configuration file. This line is not part of the configuration itself, but it tells the [yaml-language-server](https://github.com/redhat-developer/yaml-language-server) (or the respective [VSCode extension](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-yaml)) how to validate the configuration file based on the JSON schema that was generated in the previous subsection. This way, we can see if the file is correctly filled and have access to features such as autocomplete. Try to delete a parameter or input invalid data. 

> [!NOTE]
> In the previous subsection, a default value was assigned to the `session.type` parameter. Delete the line corresponding to this parameter and verify that the `yaml-language-server` doesn't present any error.

After creating the configuration file, one will want to read it in Bonsai. With that purpose in mind, let's use the following workflow and save it inside the `./src` directory. 

:::workflow
![Workflow](~/workflows/ReproducibleResearchPractices/Workflow.bonsai)
:::

The workflow just loads the configuration file and ends after the `session.duration` specified in it.

We have successfully created a configuration file that can be used in a reproducible way across different sessions in a Bonsai workflow!

<!-- ## Startup and shutdown scripts
> [!WARNING]
> _Under construction_ -->