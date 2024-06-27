# Harp.Behavior: Digital Output

## Summary
This example demonstrates how control the ON/OFF state of an LED using the digital output from the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/examples.starter/Harp/Behavior/DigitalOutput/DigitalOutput.bonsai)
:::


## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Turns the LED ON when 'A' is pressed.
3. Turns the LED OFF when 'S' is pressed

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can control four digital output ports: DO0, DO1, DO2, and DO3. In this example, the board controls the ON/OFF state of an LED connected to DO0. A resistor of 200Ohm is used to drop the current passing through the LED and prevent it from burning.

![Schematics](./DigitalOutput.png){ width=65% }

## Follow-up





