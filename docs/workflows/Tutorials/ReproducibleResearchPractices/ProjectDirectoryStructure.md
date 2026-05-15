# Project Directory Structure
It's a good practice to decide on the structure of the project directory right at the beginning. It's even better if the structure is adopted at the lab or institute level, since it makes the project easier to navigate, not only for the author(s) but also for other users.

There's no right solution for this problem, what matters is to find a solution that works for the developers (and maybe for other users if sharing the project is important). A possible project directory structure is presented below:
- `.bonsai/` - The directory containing the portable version of Bonsai installed (read on how to create a Bonsai environment [here](https://bonsai-rx.org/docs/articles/environments.html)).
- `src/`
    - `Extensions/`
    - `config/`
    - `Workflow.bonsai`
- `config/`
- `output/`
- `python/`
- `docs/`
- `README.md`
- `.gitignore`
- `Run.cmd` and `run.ps1`
- `Setup.cmd` and `setup.ps1`

## Output Directory Structure
It's not only important to organize the directory structure of the project, but it's also incredibly important to define a clear structure on how the data from a session is saved. The main benefit from doing this is that it becomes easier for the researcher to plan data analysis. This way there's no need for the researcher to adapt the data analysis scripts that compose the pipeline to every way that data is structured. 

A positive side effect of this is that it's valid for data analysis performed at different moments in time relative to its acquisition. This means that if output data is saved in a standardized way, it's relatively easy to analyze it whether it's a script that performs some pre-analysis or the analysis is made after the experiment is over or even if the analysis is only made a few years after the data was acquired and stored.

Obviously, the output directory structure depends on a variety of factors (task, number of animals, number of sessions, whether the same task/setup is being used for different experiments, etc), but, just as an example, let's think about how we could structure the output directory of a task in which the same setup can be used for different experiments, each of these experiments requires for multiple animals to perform the task, each animal has at most 1 session per day and multiple sessions across a period of approximately 2/3 months.

Given the description above, a possible directory organization could be `./[batch]/[animal]/[session]/`, where `.` is the root output directory and the name of the session directory could be the date of the session in the `YYMMDD` format. Inside every session directory, we'll want to save a CSV file (every row corresponds to a trial and the columns contain relevant variables tracked during the trial - examples: outcome, reaction times, stimulus intensity), the configuration used in the current session, the video recorded, the camera metadata and the logs from the Harp devices.
```
output/
└── batch/
    └── animal/
        └── [YYMMDD]/
            ├── out.csv
            ├── video.mp4
            ├── cam_metadata.csv
            ├── config.yml
            └── harp/
                ├── device_x
                │   ├── device_x_0.bin
                │   ├── ...
                │   ├── device_x_122.bin
                │   └── device.yml
                └── device_y
```

> [!TIP]
> It might be a good idea to append the time at which the session started to the name of the files in case there's a need to restart it.

> [!NOTE]
> The events from the Harp devices can be incredibly important to reconstruct the task, synchronize different signal sources (e.g.: camera frames with other events) or extract data that was not saved in the `out.csv` to begin with.
>
> Visit the section on how to interact with the Harp events data [here](./HarpDataAnalysis.md).