# Vision: Video Annotation

:::workflow
![Example](~/workflows/BonsaiExamples/Vision/VideoAnnotation/VideoAnnotation.bonsai)
:::

## Summary
This example demonstrates how to add a circular marker to a camera image and save the resuting annotated video. 

## Details
1. Create distribution to sample values for the X position of the circle.
2. Create distribution to sample values for the Y position of the circle.
3. Create a new circle position everytime a key is pressed.
4. Capture camera images to a behavior subject.
5. Every frame acquired will create a new canvas with the current frame and the marker. The results is saved in a video (annotated_video.avi).
6. Set the canvas size to the frame size.
7. Add current frame image to the canvas.
8. Set the x,y position of the circle and add it to the canvas.

## Follow-up
For more other annotation possibilities type 'Vision.Drawing' in the Bonsai toolbox.
