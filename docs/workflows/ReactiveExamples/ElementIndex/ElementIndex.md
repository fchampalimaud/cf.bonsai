# ElementIndex

## Summary
This example demonstrates how to get the index of each event generated in a stream. In Bonsai this is equivalent to the number of current elements generated in a stream subtracted by 1.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/ElementIndex/ElementIndex.bonsai)
:::

## Details
1. Generates an event every 100ms.
2. Computes the index of the current event.
3. Outputs the index of the current event. To obtain this node, right-click over the *ElementIndex* node and select Ouptut -> Index.

