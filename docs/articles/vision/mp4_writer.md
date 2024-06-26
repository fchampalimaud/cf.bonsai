# Vision: MP4 Writer

:::workflow
![Example](~/workflows/examples.starter/Vision/MP4Writer/MP4Writer.bonsai)
:::

## Summary
This example shows how to save a MP4 video using [FFMPEG](https://website-name.com)


## Details
0. Before running workflow download and unzip [ffmpeg](https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl-shared.zip) to a folder in your computer. 

1. Write the frames from a camera into ImageWriter, but in the path, instead of a file, you will add a pipe: \\\\.\pipe\video. Every frame that is written in the pipe is going to be sent the process in 2.

2. Start a process where the filename points to the ffmpeg executable \[ffmpeg\]\bin\ffmpeg.exe and the arguments are those of ffmpeg. Here we are using:  
-y -f rawvideo -vcodec rawvideo  -s 640x480 -r 30 -pix_fmt gray -i \\\\.\pipe\video -c:v libx264 -b:v 5212K -maxrate 5212K -bufsize 5M "myvideo.mp4"  

  Options that might need to be adapted for your situation are:
  - the size (width and height) of the input images (-s)
  - the frame rate (-r)
  - the input pixel format (-pix_fmt)
  - the name of the output video (last parameter)
  - in case the encoding is rather slow, you might want to append the option '-preset ultrafast' to speed it up.

 ## Follow-up
For additional information on the encoding options provided by ffmpeg consult the [documentation](https://ffmpeg.org/ffmpeg.html). 


