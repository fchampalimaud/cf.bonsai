
# FFmpeg

## Summary
This example shows how to convert a MP4 video using [FFmpeg](https://ffmpeg.org/).

## Workflow
:::workflow
![Example](~/workflows/BonsaiExamples/Vision/MP4Writer/MP4Writer.bonsai)
:::

## Details
0. Before running the workflow, install the `FFmpeg` software by running the following command in the terminal:

> [!WARNING]
> You need to have WinGet installed on your computer.

```
winget install Gyan.FFmpeg
```

1. Write the frames from a camera into ImageWriter, but in the path, instead of a file, you will add a pipe: `\\.\pipe\video`. Every frame that is written in the pipe is going to be sent to process in 2.

2. Start a process where the filename points to the FFmpeg executable and the arguments are those of FFmpeg. Here we are using:  
`-y -f rawvideo -vcodec rawvideo  -s 640x480 -r 30 -pix_fmt gray -i \\\\.\pipe\video -c:v libx264 -b:v 5212K -maxrate 5212K -bufsize 5M "myvideo.mp4"`

Options that might need to be adapted for your situation are:
- the size (width and height) of the input images (`-s`)
- the frame rate (`-r`)
- the input pixel format (`-pix_fmt`). Set to bgr24 for coloured images.
- the name of the output video (last parameter)
- in case the encoding is rather slow, you might want to append the option `-preset ultrafast` to speed it up.

Other options that might be useful are:
- to remove audio (`-an`)
- set to an alternative codec (`-vcodec mpeg4`). Good for colored images.
- set the quality of the encoding (`-qscale 0`), with 0 being the best quality.
- set to an alternative video codec:
    - `-c:v h264_nvenc` for NVIDIA's hardware-accelerated H.264 encoding.
    - `-c:v h264_amf` for AMDGPU's hardware-accelerated H.264 encoding.

## Follow-up
For additional information on the encoding options provided by `FFmpeg` consult the [documentation](https://ffmpeg.org/ffmpeg.html). 
