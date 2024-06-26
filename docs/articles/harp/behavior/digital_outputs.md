# Harp.Behavior: Digital Outputs

## Workflow

:::workflow
![Example](~/workflows/examples.starter/Harp/Harp.Behavior/DigitalOutputs/DigitalOutputs.bonsai)
:::

## Summary
This example demonstrates how to control the digital outputs of the Harp Behavior board. The board allows for two modes of operation of the digital ports: direct setting of the state of the port (digital control) and triggering a pulse with a given width (pulse control).
LINK TO BEHAVIOR BOARD

## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Sets directly the state of digital output D0: ON when 'A' pressed and OFF when 'S' pressed.
3. Triggers a pulse in digital port D01 (width=1000s) whenever 'A' is pressed

## Schematics
ADD Schematics
The bhavior board can control 4 digital outputs  portsXXX....

## Follow-up





