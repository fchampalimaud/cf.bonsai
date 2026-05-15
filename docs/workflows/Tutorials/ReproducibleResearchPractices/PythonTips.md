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
> [!WARNING]
> _Under construction_

## Startup and shutdown scripts
> [!WARNING]
> _Under construction_