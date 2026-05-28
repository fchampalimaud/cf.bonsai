# Harp Data Analysis
When using a Harp device, it's possible to save every single message sent by the device during an experiment. Since every message has a timestamp attached, one can reconstruct the experiment at a later stage. 

In this section, we'll focus on how one can save the logs of Harp device and access those logs during data analysis.

> [!IMPORTANT]
> To run the Bonsai workflow, you'll need to install the following packages:
> - `Bonsai.Harp`
> - `Harp.Behavior` (>=v0.2.0)
>
> To run the python code, you need to install the `harp-python` package:
> ```
> uv add harp-python # Recommended
> # or
> pip install harp-python
> ```

## Workflow
The workflow below contains the bare minimum to save the harp events in a way that can be easily open during data analysis.

:::workflow
![Example](~/workflows/ReproducibleResearchPractices/HarpDataAnalysis.bonsai)
:::

1. Establishes the connection with the Harp device and saves every message to binary files. The `DeviceCommands` and `DeviceEvents` subjects are not being used in the current example, but in a setup they are usually the interface between the device and the remaining task's code.
    1. The `GroupByRegister` node separates the messages by register, which means that instead of every message being saved in the same binary file (e.g. `device.bin`), the messages are saved to the binary file that corresponds to their register number (e.g. messages from register 0 are saved to `device_0.bin`, messages, from register 1 are saved to `device_1.bin`, etc.)
        > [!NOTE]
        > It's important that the messages are separated by register address when being saved to be able to use the `harp-python` package.
2. Saves the device metadata as `device.yml` to the same directory as the message binary files.
    > [!NOTE]
    > In some Harp device packages, the node is called `GetMetadata` instead of `GetDeviceMetadata`.

After running the workflow for some time, we'll end up with a directory called `events` that contains the following files:

```
events/
├── device_0.bin
├── device_1.bin
├── device_2.bin
├── ...
├── device_122.bin
└── device.yml

```

## Data Analysis
Eventually, we will need to make some sort of data analysis with the device events. In this tutorial, we'll simply open one of the binary files and convert it into a CSV file.
```
import harp

# Global variables with the paths to files and directories accessed in the script
EVENTS_DIRECTORY = "events"
ANALOG_DATA_BIN = "events/device_44.bin"
ANALOG_DATA_CSV = "events/device_44.csv"

# Create device reader from device.yml file
reader = harp.create_reader(EVENTS_DIRECTORY)

# Generate the pandas dataframe of the AnalogData register
df = reader.AnalogData.read(ANALOG_DATA_BIN)
df.to_csv(ANALOG_DATA_CSV)
```

It's important to note that the `harp-python` package is built on top of `pandas`, so that when we open a binary file, it gets converted into a pandas `DataFrame` object.

> [!NOTE]
> It's also possible to convert the binary files into CSV files by using the [Harp Convert To CSV](https://github.com/harp-tech/csv_converter) GUI. However, using the `harp-python` package offers more versatility (click [here](https://harp-tech.org/articles/python.html) to learn more about this package).
