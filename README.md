# F# Recursion Bug with Mutable Variables

This repository demonstrates a common error in F# involving the unintended use of mutable variables within recursive functions, leading to unexpected or infinite recursion.  The `bug.fs` file contains the erroneous code, while `bugSolution.fs` presents a corrected version.

## The Problem

In the original code, mutable variables `x` and `y` are used within the recursive function `loop1`.  However, the values of `x` and `y` are not properly managed during recursion which leads to the function running endlessly. 

## The Solution

The corrected version in `bugSolution.fs` addresses this by replacing mutable variables with immutable parameters, resolving the issue of unintended recursion.