# Count

## Summary
This example demonstrates how to get number of elements generated by a stream once it has terminated.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Count/Count.bonsai)
:::

## Details
1. Generates an event every 100ms.
2. Terminates the stream once 5 events have been generated.
3. Counts the number of events generaged by the stream.
4. Prevents Bonsai from terminating once the five events have been generated, and in doing so, it allows the user to visualize the output of the *Count* node.

