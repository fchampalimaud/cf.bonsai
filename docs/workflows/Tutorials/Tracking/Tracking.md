
# Tracking

Tracking consists of identifying the position of one or several objects in time. In this tutorial we will divide this process in two stages:

1. __Segmentation__. A pre-processing stage where we identify the pixels that belong to the object(s).  This typically involves setting a mask where the pixels of interest are set to 1, while the other are set to 0.

2. __Tracking__. This process consists of getting the actual coordinates of the objects of interest in the image. Typically this involves extracting the centroid, but other types of information, such as orientation, or size, can also be obtained.


# Tutorial
In this tutorial we learn different basic strategies to segment and track an HexBug in an arena. The video can be found [here](). We will start by describing a few segmentation strategies and then leverage on the results to obtain the position of the flies in the arena. 


## Segmentation: Thresholding

The first, and possibly the simplest, method for achieving segmentation is simple thresholding. Here, we use a color-based threshold performed in three different color spaces: 

:::workflow
![Example](~/workflows/Tutorials/Tracking/SegmentationThreshold.bonsai)
:::

1. __BGR (Blue Green and Red)__ - We define for each color channel a range of acceptable values; pixels inside the ranges in all the colors are accepted (value 1), and pixels outside of that range are rejected (value 0).

2. __HSV (Hue, Saturation and Value)__ - The pixels are first converted to HSV and only thresholded after. Unlike the BGR color-space, the HSV encodes color in a single dimension - the Hue.

3. __Grayscale__. The pixels are first converted to Grayscale and the subsequent thresholding requires only setting the lower and upper bounds of ilumination (ie. a single dimension)

__*Notes:*__

The Grayscale thresholding is the simplest method since one only has to segment in one dimension. If the contrast between your object and the background is strong enough this is usually a well suited method. It is also the only thresholding option to segment images from black and white cameras.

If you need to rely on color for the segmentation then the HSV tends to be the method of choice. Since the color is well preserved in the _Hue_ dimension across different light conditions, this color space is much more robust to changes in light intensity.



## Segmentation: Background subtraction

Another method widely used for segmentation is background subtraction, where we first estimate a background frame, and then subtract it to every frame of our video. There are a number of ways to estimate the background; here we will look at three alternatives:
:::workflow
![Example](~/workflows/Tutorials/Tracking/SegmentationBackgroundSubtraction.bonsai)
:::


1. __First frame__ - 
2. __Pixel extrema__ -
3. __Adaptive background__ -


## Segmentation: Temporal subtraction
:::workflow
![Example](~/workflows/Tutorials/Tracking/SegmentationTemporalSubtraction.bonsai)
:::



# Tracking

For tracking you can use any binarized image. The process





