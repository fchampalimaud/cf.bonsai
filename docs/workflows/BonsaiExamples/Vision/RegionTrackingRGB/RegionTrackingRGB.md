# Region Tracking RGB

## Summary
This example demonstrates how to setup a simple tracker based on thresholding the BGR channels.

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/RegionTrackingRGB/RegionTrackingRGB.bonsai)
:::

## Details
1. Opens the video file.\*
2. Thresholds each of the RGB channels between a lower and an upper bound. Modify those bounds such that your particular object can be separated from the background. Note that the order of the color channels in Bonsai is typically BGR.
3. Finds regions of contiguous pixels in the thresholded image. You can set a minimum and/or a maximum number of acceptable contiguous pixels.
4. Calculates a number of properties, for each region identified, such as position of the centroid, orientation, etc.
5. Selects the largest region from the list of all identified regions.
6. Selects the centroid region. To obtain this right-click on the *LargestBinaryRegion* node and select Output -> Centroid.
7. Selects the X and Y coordinates from the *Centroid* node. Double-click on these nodes to visualize the position of the object in the image.


\*Download this [file](https://drive.google.com/file/d/1Gh412SmoWV34jlrJfs4ZEvCMX7h-BHVj/view?usp=sharing) and set the FileName property of the *FileCapture* node accordingly.

## Visualization
While the code is running, double-click on the *FileCapture* node to open the image visualizer, and drag the *Centroid* node into the it. This will overlay the centroid onto the object on the image visualizer. After you can left-click the image visualizer and it will furher overlay a trail of the centroid trajectory of the object.


## Follow-up
See also the [RegionTrackingHSV](../RegionTrackingHSV/RegionTrackingHSV.md) example.
