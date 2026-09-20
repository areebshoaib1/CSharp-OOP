# C# Constructors & Destructors

This project contains C# OOP practice problems focused on **constructors, constructor overloading, object initialization, static members, and destructor/finalizer behavior**.

## Problems

### Problem 01 - Default and Parameterized Constructor

Create a `Product` class with private `name` and `price` fields.

Implement:

* A default constructor that sets `name` to `"Unknown"` and `price` to `0.0`
* A parameterized constructor that accepts both values

In `Main`, create one object using each constructor and display both objects to verify their initialization.

**Concepts:**

* Default constructor
* Parameterized constructor
* Private fields
* Object initialization

---

### Problem 02 - Initialize an Array Inside a Class Using a Constructor

Create a `NumberArray` class that contains a private integer array.

The constructor should:

1. Accept a `size` parameter.
2. Allocate the array using the given size.
3. Fill the array with numbers from `1` through `size`.

Add a `Display()` method to print all elements.

In `Main`, create an instance with size `10` and call `Display()`.

**Concepts:**

* Constructor parameters
* Array initialization
* Loops
* Object state

---

### Problem 03 - Count How Many Objects Are Created

Create a `Student` class with a static `objectCount` variable.

Increment `objectCount` inside every constructor.

Add a static `GetCount()` method that returns the total number of created objects.

In `Main`, create at least three `Student` objects and print the count.

**Expected result:**

```text
Object Count: 3
```

**Concepts:**

* Static fields
* Static methods
* Constructors
* Shared class-level state

---

### Problem 04 - Demonstrate Constructor Overloading

Create an `Employee` class with:

* `id`
* `name`
* `salary`

Overload its constructor three ways:

1. Parameterless constructor - sets default values.
2. One-parameter constructor - accepts only `id`.
3. Three-parameter constructor - accepts `id`, `name`, and `salary`.

In `Main`, create one object using each constructor and display their details.

**Concepts:**

* Constructor overloading
* Default values
* Parameterized constructors
* Multiple object initialization

---

### Problem 05 - Show the Order of Constructor and Destructor Calls

Create a base `Parent` class and a derived `Child` class.

Add constructors and destructors to both classes that print identifying messages.

In `Main`, instantiate a `Child` object and invoke:

```csharp
GC.Collect();
```

Observe the order in which constructors and destructors/finalizers execute.

### Constructor Order

```text
Parent Constructor
Child Constructor
```

The base class constructor executes before the derived class constructor.

### Destructor/Finalizer Order

The exercise is intended to demonstrate that finalization proceeds from the derived type toward the base type.

**Concepts:**

* Inheritance
* Constructor execution order
* Destructor/finalizer
* Garbage Collection
* `GC.Collect()`


