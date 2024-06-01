# Vision: Region Tracking RGB

:::workflow
![Example](~/workflows/examples.starter/Vision/VideoAnnotation/VideoAnnotation.bonsai)
:::

## Summary
This example demonstrates how add a circular marker to a camera image and save the annotated video. 

## Details
1. Create distribution to sample values for the X position of the circle.
2. Create distribution to sample values for the Y position of the circle.
3. Create a new circle position everytime a key is pressed.
4. Capture camera images to a behavior subject.
5. Every frame acquired will create a new canvas with the current frame and the marker. The results is saved in a video (annotated_video.avi).
    5.1 Set the canvas size to the frame size.
    5.2 Add current frame image to the canvas.
    5.3 Set the x,y position of the circle and add it to the canvas.
