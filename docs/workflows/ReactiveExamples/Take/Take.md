# Take 

## Summary
This example demonstrates how to control the end of a stream using the *Take* operator. Here, the workflow terminates after 5 key presses.


## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Take/Take.bonsai)
:::


## Details
1. Generates an event every second.
2. Propagates the first 5 event, and emits an *OnComplete* message that terminates the preceeding wokflow.
3. Terminates the main workflow when *OnComplete* message is received.


## Visualization
Visualize the output of the *Take* node using ObjectTextVisualizer enlarged, such that multiple events can be observed. 
