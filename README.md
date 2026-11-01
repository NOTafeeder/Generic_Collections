# Generic Collections

A C# console application exploring **generics** and **generic collections**, built in the Object-Oriented Programming course at Campus Varberg (Systems Developer .NET).

## What it does

- **Generic class:** `Check<T>.CheckEqual(item, item2)` compares two values of any type, using `EqualityComparer<T>.Default`.
- **`List<int>`:** adds numbers, counts them, and loops through the list.
- **`List<Employee>`:** stores employees and searches the list with built-in `List<T>` methods and lambda expressions:
  - `Contains` checks whether a specific employee is in the list
  - `Exists` checks whether any employee matches a condition
  - `Find` / `FindLast` return the first / last match
  - `FindAll` returns every match as a new list

## Concepts

Generics (`<T>`), `List<T>`, lambda expressions, classes and properties.

## Sample output

```
Are the values equal? True
Are the values equal? False
Are the values equal? False
Number of elements in the list: 3
...
Does the list contain an employee whose name starts with 'J'? True
Found employee: ID: 1, Name: John Doe, Salary: 50000,00
Found last employee: ID: 2, Name: Jane Smith, Salary: 60000,00
```

## Technologies

C# · .NET 10 · Visual Studio
