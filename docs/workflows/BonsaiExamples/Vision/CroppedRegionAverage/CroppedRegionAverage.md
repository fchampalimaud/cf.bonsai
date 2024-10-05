# Cropped Region Average

## Summary
This example demonstrates how to average the pixel intensity of a given region of an image. This could be used, for example, to identify whether a certain region of the space is being occupied by an animal.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/CroppedRegionAverage/CroppedRegionAverage.bonsai)
:::

## Details
1. Opens the video file. \*
2. Crops the region of interest.
3. Calculates the pixel average of the region of interest.
4. Selects the first channel in the video. (The average is calculated independently for evey channel; in a grayscale image only the first channel has information.)

\*Download file here.

## Follow-up
