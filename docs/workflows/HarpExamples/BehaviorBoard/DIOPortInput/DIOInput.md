# Analog Input

## Summary
This example demonstrates how to read digital input values from the DIO Port0 using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below).


## Workflow

:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/AnalogInput/AnalogInput.bonsai)
:::


## Details
1. Creates a connection with the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. 
2. Filters the messages from the Behavior board that pertain DIO port inputs.
3. Selects the DIO0 from the list of possible DIO inputs (see the output of the Parse node in 2).


## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)



