# Harp.Behavior: Log Selected

## Summary
This example demonstrates how to log the events that control the ON/OFF state of an LED using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/examples.starter/Harp/Behavior/LogSelected/LogSelected.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
    1. Filters all the messages from the Behavior board that set digital output ports to ON.
    2. Filters all the messages from the Behavior board that set digital output ports to OFF.
2. Turns the LED ON when 'A' is pressed.
3. Turns the LED OFF when 'S' is pressed


## Schematics
All the messages to and from the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) can be logged. In this example, only data relative setting and clearing of digital output ports is logged. 

![Schematics](./LogSelected.png){ width=65% }


## Follow-up
