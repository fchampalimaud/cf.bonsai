# Calibration Protocol

## Summary
This example demonstrates how to create and execute a reward delivery protocol using the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html) (see hardware schematics below).

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/SyringePump/CalibrationProtocol/CalibrationProtocol.bonsai)
:::

## Details

## Requirements
This example requires:
1. An up-to-date version of the [SyringePump firmware](https://github.com/harp-tech/device.syringepump/releases). This example used the *fw0.6-harp1.6*. To upload the new firmware double-click on the *SyringePump Device* node in Bonsai and follow the instructions.
2. The installation of the Bonsai package *Harp - SyringePump* (from nuget.org).
3. It might also be useful to download the [SyringePump GUI](https://github.com/harp-tech/device.syringepump/releases).

## Schematics
In this example, the [Harp SyringePump](https://harp-tech.org/api/Harp.SyringePump.html) controls a stepper motor.

![Schematics](./CalibrationProtocolSch.svg){ width=65% }