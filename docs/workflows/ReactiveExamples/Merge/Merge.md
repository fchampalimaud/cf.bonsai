# Merge

## Summary
This example demonstrates how to merge events from two independent streams using the *Merge* operator. In this case, presses in either 'A' or 'S' keys are propagated.


## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Merge/Merge.bonsai)
:::


## Details
1. Generates an event whenver 'A' is pressed.
2. Generates an event whenver 'S' is pressed.
3. Propagates all the input events in the order they are received.

Note: The *Merge* node requires all its input streams to produce the same datatype.


## Visualization
Visualize the output of the *Merge* node using ObjectTextVisualized enlarged, such that multiple events can be observed. 
