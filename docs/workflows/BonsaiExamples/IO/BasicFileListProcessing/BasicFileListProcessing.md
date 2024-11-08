# Basic File List Processing

## Summary
This example demonstrates how to read data from a list of files, process each file individually and create new files with the output. It reads two files containing a number each, multiplies each number by two and creates two respective output files with the result. 

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/IO/BasicFileListProcessing/BasicFileListProcessing.bonsai)
:::

## Summary
This example demostrates how to read data from a list of files in a given directory, process each file individually to create a new set of corresponding output files. The output files will be placed in the same directory as the input files.

## Details
1. Gets a list of filenames, with *\*.txt* extension, from a given directory as string array.\*
2. Generates one event per each element in the string array.
3. Processes each file individually. In this example, we read the number stored in each file, multiply it by two, and create a new file with the result with the string '_new' added to it.

\* Before running the code you need to download [file1.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/BasicFileListProcessing/test1.txt) and [file2.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/BasicFileListProcessing/test2.txt) to an empty directory, and modify the Path property in the *GetFiles* node accordingly. 


## Follow up
A more elaborated example for processing a list of files can be found [here](../SerialFileListProcessing/SerialFileListProcessing.md).
