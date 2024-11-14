# Play Sound

## Summary
This example demonstrates how to play a .wav file using the [Harp SoundCard](https://harp-tech.org/api/Harp.SoundCard.html) board from an external trigger given by the [Harp Behavior](https://harp-tech.org/api/Harp.Behavior.html) (see hardware schematics below). 

## Workflow
:::workflow
![Example](~/workflows/HarpExamples/SoundCard/PlaySound/PlaySound.bonsai)
:::

## Details
The Harp SoundCard board allows the user to upload wav files using its graphical user interface (see details here????). Each file is linked to an index (0-31), which can be played by the sound card. 
1. Establishes the commands to be sent to the SoundCard board. The PortName property in the Behavior node needs to be set to the COM device on the computer. To create the subject node, right-click on the SoundCard node -> Create Source -> Behavior Subject, and name it accordingly. 
2. Plays the sound stored at index 4, when 'A' is pressed. \*
3. Plays the sound stored at index 5, when 'S' is pressed. \*\*
4. Ensures that command messages are sent only when the device is ready.
    
\* The example file loaded in index 4 can be found here
\*\* The example file loaded in index 5 can be found here



## Requirements
This example requires the following Bonsai packages:
- Harp - SoundCard (from nuget.org)

Additionally, install the [Harp SoundCard](https://github.com/harp-tech/device.soundcard) GUI in order to upload sounds to the SoundCard.

## Schematics
The [Harp Sound Card](https://harp-tech.org/api/Harp.SoundCard.html) 

![Schematics](./SoundHardwareTriggerSch.svg){ width=65% }