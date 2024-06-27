# Harp.Behavior: Quadrature Encoder

## Summary
This example demonstrates how obtain the position values of a quadrature encoder using the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board (see hardware schematics below). 


## Workflow
:::workflow
![Example](~/workflows/examples.starter/Harp/Behavior/QuadratureEncoder/QuadratureEncoder.bonsai)
:::



## Details
1. Establishes the commands to be sent to the Behavior board. To create the subbject node, right-click on the Behavior node -> Create Source -> Behavior Subject, and name it accordingly. 
    1. Filters the messages from the Behavior board that pertain analog inputs.
    2. Selects the Encoder from the list of possible analog outputs (see the output of the Parse node in 1.2).
2. Resets the quadrature encoder counts such that the encoder starts at zero.
3. Enables the quadrature encoder


## Schematics
The [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) board can read the position value of one quadrature encoder connected to Port2. 

![Schematics](./QuadratureEncoder.png){ width=65% }


## Follow-up