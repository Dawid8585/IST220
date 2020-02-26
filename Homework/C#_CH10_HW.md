### -- Dawid Perkowski

### --File: C#_CH10_HW

1. What does an array look like in memory?

   - The items in an array live in a contiguous block of memory and are accessed by using an index, unlike fields in a structure or class, which are accessed by name.
2. Where is memory allocated to hold an array, on the stack or on the heap?
- Variable *refers* to a contiguous block of memory holding the array elements on the heap
3. Where is memory allocated to hold an array reference, on the stack or on the heap?

   - Variable *refers* to a contiguous block of memory holding the array elements on the heap
4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.” What determines the types that an array can hold?

   - The values between the braces do not have to be constants, number of values between the braces must exactly match the size of the array instance being created. Generally, it is best to avoid mixing types, hoping that the compiler will convert them for you.
5. Describe the syntax of the condition for a foreach loop.

   - int[] pins = { 9, 3, 7, 2 };
      foreach (int pin in pins)
      {
        Console.WriteLine(pin);
      }
6. How do you make a deep copy of a array?

   - If the elements in the array being copied contain references, the *Clone* method simply copies the references rather than the objects being referred to. After copying, both arrays refer to the same set of objects. If you need to create a deep copy of such an array, you must use appropriate code in a *for* loop.
7. What is the difference in the syntax between a multi-dimensional array and an array of arrays?

   -  Array of arrays (jagged arrays) are faster than multi-dimensional arrays and can be used more effectively. Multidimensional arrays have nicer syntax.
8. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words, what determines whether you would use one as opposed to the other?

   - When you want or need to run your program faster you can use jagged arrays, when you want more detailed arrays you can use multi-dimensional.
9. How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix   1 2 3 4 5 6 7 8 9   and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]? Write the code to do this in English.

   -  flat_array = array();
   -  foreach (new RecursiveIteratorIterator(new RecursiveArrayIterator(array)) as k=>v)
   -  flat_array[k]=v
   -  you would use recursion
10.  (Thought question) When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the loop. Why not? How is for different from foreach?

    -  You're changing the iteration variable `c`. That doesn't change the contents of the array. The iteration variable is just a *copy* of the array element. If you want to modify the array, you need to do so explicitly.
    
    
    

