
## Tracking an object

Tracking consists of identifying the position of one or several objects in time. In this tutorial we will divide this process in two stages:

1. __Segmentation__. A pre-processing stage where we identify the pixels that belong to the object(s).  This typically involves setting a mask where the pixels of interest are set to 1, while the others are set to 0.

2. __Tracking__. This process consists of getting the actual coordinates of the objects of interest in the image. Typically this involves estimating the centroid, but other types of information, such as orientation, or size, can also usually be obtained.

Here, we will learn different basic strategies to segment and track a single object of interest in a video. We will use [Bonsai](https://bonsai-rx.org/) to demonstrate how each strategy can be implemented. You can use these two videos as examples: [a grayscale video of a fly](https://drive.google.com/file/d/1M8dtoLliKqJpS3_Tjf7XHfsDRF5mmy9R/view?usp=sharing) and a [coloured HexBug in an arena](https://drive.google.com/file/d/1Gh412SmoWV34jlrJfs4ZEvCMX7h-BHVj/view?usp=sharing). If you are interested in multi-object tracking, you can experiment with [a grayscale video of 5 flies](https://drive.google.com/file/d/1uANrBaYXDhzKrTZaV4JeurG0xV-d611i/view?usp=sharing).


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

:::workflow
![Example](~/workflows/Tutorials/Tracking/SegmentationBackgroundSubtraction.bonsai)
:::

Another set of methods widely used for segmentation is background subtraction, where we first estimate the background, and then subtract it to every frame of our video. Background segmentation is typically used with grayscale images. There are a number of ways to estimate the background; here we will look at three alternatives:


1. __First frame__ - Takes the first frame from the video as background and subtracts it to all the other frames. This method implies that the background is taken without the object of interest present in the image.

2. __Pixel extrema__ - Takes a block of frames, typically big enough to allow the object of interest to have moved, and it collects the brightest (or the darkest) intensity for each pixel during this interval. The background is then formed by the set of lowest or highest values for each pixel (see [Guilbeault et al, 2021](https://www.nature.com/articles/s41598-021-85896-x)). A variant of this algorithm is to take, for each pixel, the median (or other percentile value) intensity across a portion of entire video.

3. __Adaptive background__ - Takes an moving average of the last N last frames and uses it as the background image. This image is then subtracted and thresholded.


__*Notes*__

The first method is rather rudimentary and relies heavily on the first frame being a good representative of the actual pixel values of the background across the entire video. Small changes in light intensity can destroy . It has the disadvantage of requiring image data with and without the object of interest.

The second method computes the background wihout requiring an explicit background image. It is quite robust and in practice very useful. Nonetheless, it still relies on a relatively stable illumination across the entire video. More fundamentally, it also relies heavily on the object to appear relatively homogeneous; if the object is composed of dark and light areas then the background estimation can become compromised. You can see this by testing the second method on the Hexbug video.

The third method, because of its adaptive nature, is usefull when the illumination conditions (or the actual background) are not static across the video. However, it is often difficult to set parameters that are robust across all the frames in a very dynamic video. Also, it tends to capture parts of the background close to the object as a part of the object itself. It also fails to identify the object when it is static. Try it yourself and test it with the Hexbug video.



## Segmentation: Temporal subtraction
:::workflow
![Example](~/workflows/Tutorials/Tracking/SegmentationTemporalSubtraction.bonsai)
:::

For the sake of completness, we can also simply subtract consecutive frames. If all that is chaning in the video is the position of the object of interest, we can assume that any meanigfull changes in pixel intensities occur where (and when) the object is moving. Like the third method above, this method fails to identify the object when it is not moving. In addition, due to the nature of the method, it tends to capture the contours of the object, rather than the full object.


## Tracking

:::workflow
![Example](~/workflows/Tutorials/Tracking/Tracking.bonsai)
:::

Once the object have been segmented from the background, we perform a stereotyped number of operations to extract the location of its centroid:
1. __Identify countours__: Identify sets of thresholded pixels that are adjacent to each other. Here we can accept and reject countours based on their minimum and/or maximum area.
2. __Calculate contour properties__: Compute basic properties of the contours identified such as centroid, area, or orientation.
3. __Select object contour__: Select among all the available contours the one that belongs to our object of interest. Commonly this will be the largest contour of all.











