// C# Console Application - Data Structures Example
using System;

namespace DataStructuresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Data Structures Demo ===\n");

            // Example 1: Basic array operations
            MyArray numbers = new MyArray(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(80);
            
            Console.WriteLine("Array after inserting values:");
            numbers.print();
            
            // Example 2: Insert at specific index
            Console.WriteLine("\nInserting 25 at index 2:");
            numbers.insertAt(25, 2);
            numbers.print();
            
            // Example 3: Find index of value
            Console.WriteLine($"\nIndex of 40: {numbers.indexOf(40)}");
            
            // Example 4: Find maximum value
            Console.WriteLine($"Maximum value: {numbers.max()}");
            
            // Example 5: Intersection with another array
            MyArray numbers2 = new MyArray(3);
            numbers2.insert(100);
            numbers2.insert(200);
            numbers2.insert(30);
            numbers2.insert(40);
            numbers2.insert(808);
            
            Console.WriteLine("\nIntersection of arrays:");
            MyArray intersection = numbers.intersect(numbers2);
            intersection.print();
            
            // Example 6: Reverse array
            Console.WriteLine("\nReversed array:");
            MyArray reversed = numbers.reverse();
            reversed.print();
        }
    }
}
