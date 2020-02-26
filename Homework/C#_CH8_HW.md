### -- Dawid Perkowski

### --File: C#_CH8_HW

1. What is the difference between deep copy and shallow copy?

   - Deep copy consists of a field that has a reference type and the reference type provides a clone
   - Shallow copy consists of the clone method copying references. 

2. What is the value of a reference after you declare and initialize it?

   - That you can call upon it while you are programming and don't get a syntax error because its uninitialized.
   
3.  How do you declare a value type?

   - You use the question mark (?) to indicate that a value type is nullable. int? i = null; // legal

4. How do you declare a reference type?

   - With doIncrement

5. . Does C# allow you to assign NULL to a value type?

   - Yes it can with the ""?"

6.  Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

   - Yes cause the null  will take place of the value.

7. What is the difference between the stack and the heap?

   -  Objects allocated to the Heap can be accessed from anywhere while objects from the stack are only available from the stack frame.

8. What does it mean when we say that all classes are specialized types?

   - In the book it said that to give a base line while describing what system.object class is

9. What does ref do?

   - Its when you used a reference in a method parameter to invoke your value.

10. What does out do?

    -  Out defines the parameter in the method right away and returns it.

11.  Describe boxing and unboxing in your own words

    - It reads and converts a value from a stack to a heap and vice versa.

12. What does cast do?

    - This is an operation that checks whether converting an item of one type to another is safe before actually making the copy.
    

    


