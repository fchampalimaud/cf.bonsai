# Scripting.Expressions: Convert Basic Types

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/Scripting.Expressions/BasicTypeConversions/BasicTypeConversions.bonsai)
:::


## Summary
This example demostrates how to convert across the different numeric data types using direct CSharp expressions in the ExpressionTransform node.

## Details
1. Generates an int value
2. Converts the int into a float value using the method Convert.ToSingle() method
3. Converts the float into a double value using the method Convert.ToDouble() method
4. Converts the double into a string using the method Convert.ToString() method
5. Converts the string back to an int value using the method Convert.ToIt32() method
6. Converts the int into a time value (in ms) using the method TimeSpan.FromMilliseconds() method

The *it* argument passed to each method inside the ExpressionTransform nodes represents the actual input value of the node.

