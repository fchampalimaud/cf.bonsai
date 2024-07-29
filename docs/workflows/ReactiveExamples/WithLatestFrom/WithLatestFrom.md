# With Latest From 

## Summary
This example demonstrates how to sample the latest values of a *Timer* sequence whenever a key is pressed.


## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/WithLatestFrom/WithLatestFrom.bonsai)
:::


## Details
1. Generates an event whenever a key is pressed.
2. Generates the next element of a counter every second.
3. Pairs every key pressed with the current value of the *Timer*.
4. Propagates *Timer* values that have been paired with the key presses in 3. 


## Visualization

Compare the output of the *Timer* node with that of the *Item2* node. Use ObjectTextVisualizer enlarged, such that multiple events can be observed. 

