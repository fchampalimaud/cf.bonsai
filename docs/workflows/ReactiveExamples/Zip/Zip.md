# Zip

## Summary
This example demonstrates how to combine two streams using the *Zip* operator. This operator pairs events from multiple streams whenever they have all produced a value. Here, we pair the last two keypresses.


## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/Zip/Zip.bonsai)
:::


## Details
1. Generates an event whenver a key is pressed.
2. Skips the first key pressed.
3. Creates a pair of values, a *Tupple*, with the current and the last keys pressed.

Note: Because the *Zip* node pairs events only when all streams have emited a new value, the first event generated directly from the *KeyDown* in the first stream will be held until an event is produced by the *Skip* node in the second stream. This will happen only when a second key is pressed. Once this happens an event is propagated on the *Skip* node, and pair can then be formed with the previous key press on the first stream (the one being held), and the current key pressed on the second stream.

## Visualization
Visualize the output of the *KeyPress*, *Skip* and *Zip* nodes using ObjectTextVisualized enlarged, such that multiple events can be observed in each. 
