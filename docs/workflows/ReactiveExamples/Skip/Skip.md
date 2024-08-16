# Skip 

## Summary
This example demonstrates how to control the beginning of a stream using the *Skip* operator. Here, values are propagated only after 5 events have been received.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Skip/Skip.bonsai)
:::

## Details
1. Generates an event every second.
2. Prevents the propagation of the first 5 events, and starts propagating after.

## Visualization

Compare the output of the *Timer* node with that of the *Skip* node. Use ObjectTextVisualizer enlarged, such that multiple events can be observed. 
