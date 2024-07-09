# Region Tracking HSV

## Workflow

:::workflow
![Example](~/workflows/BonsaiExamples/Vision/RegionTrackingHSV/RegionTrackingHSV.bonsai)
:::

## Summary
This example demonstrates how to setup a simple tracker based on thresholding the HSV channels.

## Details
1. Convert the image to HSV space (hue, saturation, value). This space is advantageous because it allows the user to separate colors, using only the hue channel, independently of the overall image brightness. 
2. Threshold each of the HSV channels between a lower and an upper bound. Modify those bounds such that your particular object can be separated from the background. 
3. In the thresholded image, find regions of contiguous pixels. You can set a minimum and/or a maximum number of acceptable contiguous pixels.
4. For each region identified, calculate a number of properties, such as position of the centoid, orientation, etc.
5. From the list of selected regions, select the largest region and show the x and y position of the centroid.

## Follow-up
See also RegionTrakingRGB [ADD LINK] example.

