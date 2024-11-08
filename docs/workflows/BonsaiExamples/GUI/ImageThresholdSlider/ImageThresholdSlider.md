# Image Threshold Slider

## Summary
This example demonstrates how to combine different GUI elements into a single window to control and visualize the output of image thresholding.

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/GUI/StartCameraSubPanel/StartCameraSubPanel.bonsai)
:::

## Details
1. Creates a workflow to perform simple image thesholdig.
    1. Converts the image to grayscale
    2. Creates a *BehaviorSubject* to receive the grayscale images. This subject will used for the GUI panel (see 2.3).
    3. Thresholds the current image according with the latest values received in the *SliderValue* subject node (see 2.1).
    4. Creates a *BehaviorSubject* to receive the thresholded images. This subject will used for the GUI panel (see 2.4).

2. Creates a 2x2 panel to encorporate all the GUI elements. Double-lick on this node to visualize the GUI panel.
    1. Adds a slider element to the GUI. The value of the slider is sent to the *SliderValue* subject and it will modify the threshold value in 1.3.
    2. Adds a plot of the current threshold value set in the slider.
    3. Adds the grayscale image to the GUI.
    4. Adds the thresholded image to the GUI.


## Requirements
You need to install the Bonsai.Gui package available in the nuget.org package source.