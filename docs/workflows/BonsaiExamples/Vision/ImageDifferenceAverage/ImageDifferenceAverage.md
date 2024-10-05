# Image Difference Average

## Summary
This example demonstrates how to subtract consecutive frames in a video and obtain an average the result. Such a simple technique can be used to estimate the amount of motion in a video.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/ImageDifferenceAverage/ImageDifferenceAverage.bonsai)
:::

## Details
1. Gets frames from a camera.
2. Creates a grayscale version of the frames.
3. Skips one frame. 
4. Zips the current frame with the previous one.
5. Subtracts the previous frame to the current one. 
6. Averages the frame resulting from the subtracted images.

