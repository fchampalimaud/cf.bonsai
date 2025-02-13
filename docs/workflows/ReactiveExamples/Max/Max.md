# Max

## Summary
This example demonstrates how the maximum value generated by a stream once it has terminated using the [*Max*](https://bonsai-rx.org/docs/api/Bonsai.Reactive.Max.html) operator.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Max/Max.bonsai)
:::

## Details
1. Generates a counter that starts at 0 and gets incremented every 200ms.
2. Terminates the stream once 5 events have been generated.
3. Emits the maximum value generaged by the stream. 
4. Prevents Bonsai from terminating once the five events have been generated, and in doing so, it allows the user to visualize the output of the *Max* node.


## Visualization
Visualize the output of both the *Timer* and *Max* nodes using the ObjectTextVisualizer enlarged, such that all the elements generated by each node can be observed. 
Also, make the visualizers are all open at the start of the program so that no element is left out.