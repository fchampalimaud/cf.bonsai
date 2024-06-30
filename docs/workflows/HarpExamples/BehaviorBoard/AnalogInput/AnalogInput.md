# Harp.Behavior: Analog Input

## Summary
This example demonstrates how to get the analog input values from a potentiometer using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below).


## Workflow

:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/AnalogInput/AnalogInput.bonsai)
:::


## Details
1. Creates a connection with the Behavior board. 
2. Filters the messages from the Behavior board that pertain analog inputs.
3. Selects the AnalogInput0 (AD0) from the list of possible analog outputs (see the output of the Parse node in 2).

## Requirements
This example requires the folowing Bonsai packages:
- Bonsai - Harp Library
- Harp - Behavior

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board has two analog input channels: AD0 and AD1. In this example, the board receives an analog input signal from a potentiometer connected to AD0.

![Schematics](./AnalogInput.png){ width=65% }



## Follow-up
