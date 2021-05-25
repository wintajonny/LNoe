# Lab 1 - C# Syntax

## Command line arguments, user input 

1. Create a new C# console application
2. Allow the user to enter two optional number via command lines, e.g. `dotnet run -- 38 4`
3. Show an error if more than two values are entered via command line
4. If not enough numbers were entered, ask the user for the missing numbers with `Console.ReadLine`
5. Add the numbers and write the result

## Traffic Light, Switch Expressions

1. Create a new C# console application
1. Declare an enum type for the TrafficLight with values Amber, Red, Green
2. Create a method to return a different traffic light based on the received traffic light - using switch expressions
3. Invoke this method from the Main method multiple times, and use Thread.Sleep to specify a delay between the lights

## Strings

1. Create a new C# console application
1. Let the user input a string, and read it using Console.ReadLine
2. Experiment with ranges and indices working with the string