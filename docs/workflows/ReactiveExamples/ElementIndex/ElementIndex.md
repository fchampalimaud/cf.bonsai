# Element Index

## Summary
This example demonstrates how to get the index of each event generated in a stream. In Bonsai this is equivalent to the number of current elements generated in a stream subtracted by 1.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/ElementIndex/ElementIndex.bonsai)
:::

## Details
1. Generates an event every 100ms.
2. Computs the index of the current event.
3. Outputs the index of the current event. To obtain this node, write-click over the ElementIndex node select Ouptut -> Index.

