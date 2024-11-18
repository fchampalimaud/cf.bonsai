# Nose Poke Detection

## Summary
This example demonstrates how to detect a rodent nose poke using the [Mice Poke](https://github.com/harp-tech/peripheral.micepoke) peripheral for the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/NosePokeDetection/NosePokeDetection.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly.
2. Reads the state of the nose poke.
    1. Filters the messages from the Behavior board that pertain the digital inputs. 
    2. Selects the poke port DIPort0.
    3. Converts the output of 2. to Int.
    4. Outputs values only when the value of the specific poke port (DIPort0) has changed.

## Requirements
This example requires the following Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board has dedicated inputs for three nose pokes: DIPort0, DIPort1 and DIPort2. In this example, the board receives inputs from port DIPort0.

TODO: Add schematics

