# Nose Poke LED Toggle

## Summary
This example demonstrates how to toggle the built-in LED from the [Mice Poke](https://github.com/harp-tech/peripheral.micepoke) peripheral for the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/NosePokeLEDToggle/NosePokeLEDToggle.bonsai)
:::

## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly.
2. Turns off the LED in the digital output port DOPort0. 
3. Toggles the LED whenever 'A' is pressed.
4. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the following Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control LEDs for three nose pokes: DOPort0, DOPort1 and DOPort2. In this example, the board controls the LED in port DOPort0.

TODO: Add schematics
