### -- Dawid Perkowski

### --File: C#_CH11_HW

1. What is a parameter array?

   - Useful if you want to write methods that can take any number of arguments, possibly of different types, as parameters. 
2. How do you define a method that takes an arbitrary number of arguments?
- They are allocated on the stack.
3. How do you call a method that takes an arbitrary number of arguments?

   -   public static int Min(int[] paramList) , int min = Util.Min(new int[] {first, second, third});, you can use the key word Params
   
4. Why can’t you use an array to pass an arbitrary number of arguments to a method?

   - You can’t use the *params* keyword with multidimensional arrays.
   - You can’t overload a method based solely on the *params* keyword. The *params* keyword does not form part of a method’s signature.
   
5. How many parameters can a method have?

   - You can have only one *params* array per method.
   
6. Do parameter arguments have to have the same type?

   - NO, Overloading a method is very useful for cases in which you want to perform the same action on arguments of different types.
   - *Black.Hole*
   
7. What is the difference between a method that takes a parameter argument and one that takes optional arguments?

   -  Generally, you use parameter arrays for methods that can take any number of parameters (including none), whereas you use optional parameters only where it is not convenient to force a caller to provide an argument for every parameter.
   
8.  How do you define a method that takes different (and arbitrary) types of arguments?

   - Parameter array effectively has a completely arbitrary list of parameters

9. Write a method that accepts any number of arguments of a given type.

   -  someType Method(params bool[] flags)
       {
       .  ..
       }

10.  Write a method that accepts any number of arguments of any type.

    - someType Method(params object[] paramList)

      {
        ...
      }

    


