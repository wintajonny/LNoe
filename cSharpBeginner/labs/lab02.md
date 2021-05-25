# Lab 2 - Classes, Structs, Records, Tuples

## Classes

1. Create a new console application **RacersSample**
1. Create a class `Racer`
2. Create properties `FirstName`, `LastName`, `Starts`, `Wins`, `RacingTeam`
3. The `RacingTeam` property should be a nullable string, other properties of type string and int
3. Create a constructor to fill the properties
4. Create instances of `Racer` objects and use it to display values

## Structs

1. Create a console application **StructsSample**
2. Create a struct containing an int data member
3. Create a method that received a parameter of this struct
4. Change the int data member
5. What happens with the data member in the calling method? Does the member change here as well? Why or why not? What can be done?

## Records

1. Create a console application **RecordsSample**
2. Create a `Book` *positional* record with `Title`, `Publisher`, and `Isbn` properties
3. Create objects of the Book type, use the equals operator to check for equality, use the `with` expression to create a clone and change values, use deconstruction
4. Find out - what functionality is not implemented with *nominal* records?

## Tuples

1. Create a console application **TrafficLight**
1. Extend the switch expression sample from Monday to use tuples for the traffic light to allow for this sequence (extend the TrafficLight enum):

> Amber - Red - Amber - Green - GreenBlink - Amber

