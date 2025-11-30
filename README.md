# Data Structures Practice - C# Implementation

A C# console application demonstrating custom data structure implementations for learning and practice purposes.

## Overview

This project implements a custom dynamic array (`MyArray`) class in C# that demonstrates fundamental data structure concepts including:
- Dynamic array resizing
- Insertion and deletion operations
- Array manipulation methods (intersection, reversal)
- Index-based operations

## Features

The `MyArray` class provides the following operations:

- **`insert(item)`** - Adds an item to the end of the array, automatically resizing if needed
- **`insertAt(item, index)`** - Inserts an item at a specific index
- **`removeAt(index)`** - Removes an item at the specified index
- **`indexOf(value)`** - Returns the index of the first occurrence of a value, or -1 if not found
- **`max()`** - Returns the maximum value in the array
- **`intersect(otherArray)`** - Returns a new array containing common elements between two arrays
- **`reverse()`** - Returns a new array with elements in reverse order
- **`print()`** - Displays all elements in the array

## Requirements

- .NET 9.0 SDK or later

## How to Run

1. Clone this repository
2. Navigate to the `DataStructuresApp` directory
3. Run the application:
   ```bash
   dotnet run
   ```

## Project Structure

```
DataStructuresApp/
├── Program.cs      # Main entry point with example usage
├── Array.cs        # MyArray class implementation
└── DataStructuresApp.csproj  # Project configuration
```

## Learning Objectives

This project is designed for:
- Understanding dynamic array implementation
- Learning about array resizing strategies
- Practicing basic data structure operations
- Exploring C# programming concepts

## License

This is a practice/educational project. Feel free to use it for learning purposes.

