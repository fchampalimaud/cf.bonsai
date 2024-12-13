# WindowTrigger

## Summary
This example demonstrates how to create a new video, with a fixed number of frames, whenever a key is pressed, using the [*WindowTrigger*](https://bonsai-rx.org/docs/api/Bonsai.Reactive.WindowTrigger.html) operator.

## Workflow

:::workflow
![Example](~/workflows/ReactiveExamples/WindowTrigger/WindowTrigger.bonsai)
:::

## Details
1. Captures the frames of a camera.
2. Emits a signal every time the key 'A' is pressed.
3. Creates a window containing 100 frames whenever 'A' is pressed.
4. Unpacks the content of each window and creates a video file with the 100 frames for every window received. 

## Visualization
Visualize the output of the *CameraCapture* node and the *SaveVideos* node using IplImageVisualizer. Compare the outputs of each whenever the key 'A' is pressed. 

If you don't have a camera, you can substitute the *CameraCapture* node by a *FileCapture* node and open a video on your computer.

