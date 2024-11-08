# Group N Events Into Array

## Summary
This example demostrates how to group a number of events and output them as arrays.

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/DataTypes/GroupNEventsIntoArray/GroupNEventsIntoArray.bonsai)
:::

## Details
1. Generates a counter that emits a new value every 0.5s.
2. Creates a group for every 3 events, and propagates each group separately.
3. Transforms every group of 3 events into an array of 3 elements. This is done using a *Take* node (Count=3) followed by a *ToArray* node, inside a *CreateArray* group node (see inside the *CreateArray* node).
4. Returns the values in of the 3 indexes of each array generated in 3.
5. Zips the elements of each array index for visualization purposes. Double-click on this node to visualize the first three elements of the array.

