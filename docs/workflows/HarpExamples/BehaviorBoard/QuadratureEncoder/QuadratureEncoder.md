# Harp.Behavior: Quadrature Encoder

## Summary
This example demonstrates how obtain the position values of a quadrature encoder using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/HarpExamples/BehaviorBoard/QuadratureEncoder/QuadratureEncoder.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board and publishes all the events from the device. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
    1. Filters the messages from the Behavior board that pertain analog inputs.
    2. Selects the Encoder from the list of possible analog outputs (see the output of the Parse node in 1.2).
2. Resets the quadrature encoder counts such that the encoder starts at zero.
3. Enables the quadrature encoder.
4. Ensures that command messages are sent only when the device is ready.

## Requirements
This example requires the folowing Bonsai packages:
- Harp - Behavior (from nuget.org)

## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can read the position value of one quadrature encoder connected to Port2. 

![Schematics](./QuadratureEncoder.png){ width=65% }

