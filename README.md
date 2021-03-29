# Raindrops
A simple program that outputs strings based on the numerical input. Has a lite WPF front end with a small explanation tab. The background of the App changes depending on the input.

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
+ Explanation: class that contains methods to return prime factors of a given numerical input as well as an explanation as to how the method in raindrop worked, depending on the input. This is to be displayed in the wpf

## Test classes

Unit tests for the methods in the function classes.

### Raindrop Tests

Unit tests have been created to cover all unit cases, including positive and negative cases for each:

+ Input of 0
+ Input not divisible by 3, 5 or 7
+ Input divisible by 3 but not 5 or 7
+ Input divisible by 5 but not 3 or 7
+ Input divisible by 7 but not 3 or 5
+ Input divisible by 3 and 5 but not 7
+ Input divisible by 5 and 7 but not 3
+ Input divisible by 3 and 7 but not 5
+ Input divisible by 3, 5 and 7

### Explanation Tests

Unit tests have also been implemented for the Explanation class which tests both the Prime Factorisation and Reasoning method to the same extent as the Raindrop method.

## WPF

Added a lite WPF front end. It has a text box that takes in the input integer and displays PlingPlangPlong depending on the input. It also handles argument exceptions by outputting "Please enter an integer!" if an improper input has been entered.

The background of the WPF also changed depending on the output!
