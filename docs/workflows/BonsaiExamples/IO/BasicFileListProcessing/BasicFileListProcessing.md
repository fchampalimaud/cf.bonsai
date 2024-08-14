# Basic File List Processing

## Summary
This example demonstrates how to read data from a list of files, process each file individually and create new files with the output.

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/IO/BasicFileListProcessing/BasicFileListProcessing.bonsai)
:::

## Details
1. Gets a list of filenames from a given directory as string array.*
2. Generates one event per each element in the string array.
3. Processes each file individually. In this example, we read the number stored in each file, multiply it by two, and create a new file with the result with the string '_new' added to it.

*Before running the code you need to download [file1.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/ProcessFileList/file1.txt) and [file2.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/ProcessFileList/file1.txt) to a directory, and modify the Path property in the GetFiles node accordingly. 


## Follow up
A more elaborated example for processing a list of files can be found [here](../ElaborateFileListProcessing/ElaborateFileListProcessing.md).
