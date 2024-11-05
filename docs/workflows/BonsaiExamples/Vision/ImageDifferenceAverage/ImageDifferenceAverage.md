# Image Difference Average

## Summary
This example demonstrates how to subtract consecutive frames in a video, and average the absolute value of the result. Such a simple technique can be used to estimate the amount of motion in an animal.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/ImageDifferenceAverage/ImageDifferenceAverage.bonsai)
:::

## Details
1. Opens the video file.\*
2. Creates a grayscale version of the frames.
3. Skips one frame. 
4. Zips the current frame with the previous one.
5. Subtracts the previous frame to the current one. 
6. Computes the absolute value of the pixels in the subtracted image. \*\*
7. Averages all the pixels of the resulting image.


\*Download this [file](https://drive.google.com/file/d/1Gh412SmoWV34jlrJfs4ZEvCMX7h-BHVj/view?usp=sharing) and set the FileName property of the *FileCapture* node accordingly.

\*\* Often, the *Power* function is used instead of the absolute value.