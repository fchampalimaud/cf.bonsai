# Process file list

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/IO/ProcessFileList/ProcessFileList.bonsai)
:::

## Summary
This example demostrates how to read data from a list of files, process each file individually and create new files with the output.

## Details
1. Gets a list of filenames from a given directory as string array.*
2. Generates one event per each element in the string array.
3. Processes each file individually. In this example, we read the number stored in each file, multiply it by two, and create a new file with the result with the string '_new' added to it.

*Before running the code you need to download [file1.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/ProcessFileList/file1.txt) and [file2.txt](https://github.com/fchampalimaud/cf.bonsai/blob/main/docs/workflows/BonsaiExamples/IO/ProcessFileList/file1.txt) to a directory, and modify the Path propery in the GetFiles node accordingly. 



