# Harp.Behavior: Digital Output

## Summary
This example demonstrates how to control the ON/OFF state of an LED using the digital output from the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/DigitalOutput/DigitalOutput.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Turns the LED ON when 'A' is pressed.
3. Turns the LED OFF when 'S' is pressed

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control four digital output ports: DO0, DO1, DO2, and DO3. The maximum tension used is 5V. In this example, the board controls the ON/OFF state of an LED connected to DO0. A resistor of 200Ohm is used to drop the current passing through the LED and prevent it from burning.

![Schematics](./DigitalOutput.png){ width=65% }

## Follow-up





