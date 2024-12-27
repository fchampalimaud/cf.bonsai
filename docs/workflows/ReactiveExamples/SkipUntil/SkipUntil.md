# SkipUntil 

## Summary
This example demonstrates how to control the beginning of a stream using the *SkipUntil* operator. Here, values are propagated only after a key has been pressed.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/SkipUntil/SkipUntil.bonsai)
:::

## Details
1. Generates an event every second.
2. Holds the propagation of events until the 'S' key is pressed; it starts propagating after.

## Visualization

Compare the output of the *Timer* node with that of the *SkipUntil* node. Use ObjectTextVisualizer enlarged, such that multiple events can be observed. 
