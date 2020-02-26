### -- Dawid Perkowski

### --File: C#_CH12_HW

1. . How does inheritance promote the principle of don’t repeat yourself (DRY)?

   - (DRY) principle states that duplication in logic should be eliminated via abstraction; duplication in process should be eliminated via automation. Inheritance allows you to use code multiple times without rewriting it.
2. What is the syntax of a derived class that inherits from a base class?
- class DerivedClass : BaseClass
   {
     ...
   }
3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?

   -   Yes they do inherit from the same base class.
4. What happens if you do not have a default constructor in a base class when creating a derived class?

   - If you dont have a constructor you can call them in the derived class.
5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?

   - You can not because you you cannot refrence different base classes.
6. Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?

   - No, that's not possible since assigning it to a derived class reference would be like saying Base class is a fully capable substitute for derived class, it can do everything he derived class can do, which is not true since derived classes in general offer more functionality than their base class
   - You could write a constructor in the derived class taking a base class object as parameter, copying the values.
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?

   -  No not all. Not all Mammales are Horses.
8.   Under what circumstances would you want to use the new keyword when defining a method in a derived class?

   - However, it is possible to refer to an object from a variable of a different type as long as the type used is a class that is higher up the inheritance hierarchy.
9. What is a virtual method? Why would you want to define a virtual method?

   -  A method that is intended to be overridden is called a *virtual* method.	 
10. What does override do? Why does it do it?
    - The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
11.  How do you define an extension type.
    - Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type. 
12. Why do you define an extension type? 
    - To add functionality to a class or object to change the class.
13. . (Not in book) Explain the Liskov substitution principle.
    - Is a concept in Object Oriented Programming that states: Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.


