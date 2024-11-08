# Video Annotation

## Summary
This example demonstrates how to add a circular marker to a camera image and save the resulting annotated video. 

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/VideoAnnotation/VideoAnnotation.bonsai)
:::

## Details
1. Creates distribution to sample random point coordinates for the position of the circle.
2. Creates a new circle position everytime the 'A' key is pressed.
3. Capture camera images to a behavior subject.
4. Creates a new canvas with the current frame and the marker every time a new frame is acquired. 
5. Sets the canvas size to the frame size.
6. Adds current frame image to the canvas.
7. Sets the x,y position of the circle and add it to the canvas.
8. Draws the canvas into an image. Double-click in this node to visualize this node, and press 'A' several times, to observe the annotation process.

## Follow-up
For more other annotation possibilities type 'Vision.Drawing' in the Bonsai toolbox.
