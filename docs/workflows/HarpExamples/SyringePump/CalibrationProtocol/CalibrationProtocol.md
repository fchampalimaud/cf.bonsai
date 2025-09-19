# Calibration Protocol

## Summary
This article demonstrates how to calibrate the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html) (see hardware schematics below), based on the protocol written by Naz Belkaya and Sofia Freitas, and with the contribution of Teresa Serradas Duarte.

## Procedure
1. Define the Step Mode
    - Set the desired step mode (step 1 of the [Details](#details) section).
    - Set the number of protocol repetitions (step 2.2 of the [Details](#details) section).
2. Prepare for the Calibration
    - Gather the required materials: water, SyringePumps and 7 empty Eppendorf tubes.
    - Weigh each empty Eppendorf tube and record the initial weights in the spreadsheet.
3. Connect the Pumps
    - Connect the pumps to the computer via the designated COM port (e.g., COM6). Ensure that each pump is identified separately.
    - Verify that all pumps are communicating correctly.
4. Initial Step Count Testing
    - Start the calibration with a step count of **5**. You will increase the step count by increments of 5 up to a maximum of 35 for testing.
    - The step counts to be tested are: **5**, **10**, **15**, **20**, **25**, **30**, **35**.
5. Calibrate Each Pump with Different Step Counts
    - For each of the 7 Eppendorf tubes:
        - Assign a different step count from the list above.
        - Adjust the step count in the Bonsai workflow and prepare the pump accordingly.
        - Run the Bonsai workflow.
6. Record Post-Dispensing Weights
    - After completing the steps above for each tube, weigh the tubes again.
    - Record the post-filling weights in the spreadsheet alongside the corresponding step count.
7. Curve Fitting and Data Analysis
    - Use the recorded data (step counts and corresponding water weights) to fit the curve (Excel, Python, MATLAB).
8. Final Step
    - Using the results, identify the optimal number of steps for dispensing the desired amount of liquid for your experiment or setup.

> [!NOTE]
> It's expected that the calibration for syringes with equal sections give similar results, because since a motor step corresponds to a linear movement perpendicular to the syringe section, the mass of water dispensed is proportional to the syringe section for a given step mode-step count combination.

### Mass-to-Volume Water Conversion
Since we want the relation between the number of steps and the volume of water dispensed during the execution of a single protocol, we need to convert the mass of water measured into volume, taking into account the $n$ repetitions of the protocol:

$$V (\mu\text{L}) = \frac{m (\text{g})}{\text{number of repetitions} \times 10^{-3} (\text{g/}\mu\text{L})}$$

where $V$ is the volume of water and $m$ is the corresponding mass.

## Bonsai Workflow
:::workflow
![Example](~/workflows/HarpExamples/SyringePump/CalibrationProtocol/CalibrationProtocol.bonsai)
:::

### Details
1. Initializes the Harp SyringePump and configures the protocol to be used (identical to what is done in the [Create and Execute Protocol](https://fchampalimaud.github.io/cf.bonsai/workflows/HarpExamples/SyringePump/CreateAndExecuteProtocol/CreateAndExecuteProtocol.html) example). Please set the PortName, ProtocolStepCount and the StepMode properties to be used in the protocol before starting the workflow.
2. Executes the protocol defined in step 1.
    1. Enables the motor so that the protocol can be executed.
    2. This is where the protocol is actually executed $n$ times so that the calibration is done accurately. Set the Count (number of repetitions) and DelayTime properties adequately before starting the workflow. The DelayTime should be greater than the time it takes for the SyringePump to execute a protocol, which is given by $\text{step period} \times \text{step count}$ (The default $\text{step period}$ is 10 ms). Read the [Protocol SelectMany](#protocol-selectmany) section to see how it's implemented.
    3. Disables the motor so that the controller doesn't heat up when it's not being used.

#### Protocol SelectMany
:::workflow
![Example](~/workflows/HarpExamples/SyringePump/CalibrationProtocol/ProtocolSelectMany.bonsai)
:::

1. Starts the protocol defined in the step 1 of the [Details](#details) section.
2. Delays the data stream so that the protocol isn't stopped before it finishes. Beware that for the defined protocol the 2-second delay is enough, but it might not be enough for other protocols. This delay must be adapted according to the protocol used, as mentioned in the step 2 of the [Details](#details) section.
3. Stops the protocol.
4. Repeats this workflow $n$ times and returns only the event from the $n$-th repetition.

### Requirements
This example requires:
1. An up-to-date version of the [SyringePump firmware](https://github.com/harp-tech/device.syringepump/releases). This example used the *fw0.6-harp1.6*. To upload the new firmware double-click on the *SyringePump Device* node in Bonsai and follow the instructions.
2. The installation of the Bonsai package *Harp - SyringePump* (from nuget.org).
3. It might also be useful to download the [SyringePump GUI](https://github.com/harp-tech/device.syringepump/releases).
