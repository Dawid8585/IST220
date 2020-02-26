### -- Dawid Perkowski

### --File: C#_CH7_HW

1. What is a class? According to the book, what does a class “arrange?

   - *Class* is the root word of the term *classification*. When you design a class, you systematically arrange information and behavior into a meaningful entity.

2. What are the two purposes of encapsulation?

   - To combine methods and data within a class; in other words, to support classification
   - To control the accessibility of the methods and data; in other words, to control the use of the class

3.  How do you instantiate an instance of a class? How do you access that instance?

   - Through class methods and properties. Using the NEW keyword.

4. - What is the default access of the fields and methods of a class? How do you change the default?

     - Private and change it by declaring public.

5. What is the syntax for writing a constructor?

   - className( parameterList)

     {

     Statements involving the variables of the class and the parameters in the parmeterList

     }

6. What is the difference between class fields and methods, and instance fields ad methods? How do you create class fields and methods?

   - Static methods are also called *class methods*. However, static fields aren’t usually called *class fields*; they’re just called *static fields* 

7. How do you bring a static class in scope? Why would you want to bring a static class in scope?

   - USING. Enable you to bring a class into scope and omit the class name when accessing static members. 

8. Can you think of a good reason to create an anonymous class? What is it?

   - Useful when you create types for “use and throw” purposes. You would *not* need to declare a class or a struct for every time you *need* a temporary type, so, use anonymous types. Let the compiler define it for you.

9. What is polymorphism as this term is used in computer science? This is not in the book.

   - Using methods it allows us to perform a single action in different ways.

10. What is message passing as this term is used in computer science? This is not in the book.

    - It's called message passing to distinguish it from the imperative notion of "calling a function", and to reinforce the idea that the receiving object decides what to do. On the call site, you just tell the receiver the "message".

11.  What was the first object-oriented programming language?

    - Simula

12. Who is Alexander Stephanov? What do you think about this quote?

    - He is a Russian-American computer programmer,  the primary designer and implementer of the C++.
    - 

    

    

