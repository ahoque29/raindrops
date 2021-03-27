# Raindrops
A simple program that outputs strings based on the numerical input.

# Specifications

### Instructions

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the number's factors

+ If the number has a factor of 3, output 'Pling'
+ If the number has a factor of 5, output 'Plang'
+ If the number has a factor of 7, output 'Plong'
+ If the number does not have any of the above as a factor, simply return the number's digits.

### Examples
+ 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
+ 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
+ 34's factors are 1, 2, 17, and 34: this would be '34'

# Documentation

## Function classes

The project has been done with C#. It contains the following function classes:

+ Raindrops: class that contains the method that returns PlingPlangPlong depending on the input.
+ Explanation: class that contains methods to return prime factors of a given numerical input as well as an explanation as to how the method in raindrop worked, depending on the input.

## Test classes

Unit tests for the methods in the function classes.
