# Data Acquisition

## Summary
This example demonstrates how to acquire capacitance data with the [Harp FlyPAD](https://github.com/fchampalimaud/device.flypad).

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/FlyPAD/DataAcquisition/DataAcquisition.bonsai)
:::

## Details
1. Creates a subject node to send commands to the `Harp FlyPAD` and publishes all the events from the device. The `PortName` property in the `FlyPAD` node needs to be set to the COM device on the computer. To create the subject node, right-click on the `FlyPAD` node -> `Create Source` -> `Behavior Subject`, and name it accordingly.
    1. Filters event messages associated with the capacitance values acquired.
2. Starts the acquisition of capacitance data.
3. Ensures that command messages are sent only when the device is ready.
4. Saves all of the messages sent by the `Harp FlyPAD` into binary files.
5. Saves the device metadata of the `Harp FlyPAD` to the same folder as the binary files so that these can be easily parsed with the [harp-data](https://harp-tech.org/python/api/data/) Python package.

## Requirements
This example requires the following Bonsai packages:
- Harp - FlyPAD