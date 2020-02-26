### -- Dawid Perkowski

### --File: C#_CH9_HW

1. What is an enum?

   - Is a [value type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types) defined by a set of named constants of the underlying [integral numeric](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) type. To define an enumeration type, use the `enum` keyword and specify the names of *enum members*:
2. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, Corporal, Sergeant or Lieutenant, Captain, Major?
- enum ranks(Private, Corporal, Sergeant or Lieutenant, Captain, Major;
3. Using the Ranks enum, assign a rank to yourself and a friend.

   - rank dawid = rank.Sergeant;
4. Determine the numeric index of particular ranks, using the Ranks enum.

   - The place theyare in inside of the enum justifies the numeric index starting from 0 to etc.
5. How do you select the type of an enum?

   - enum Rank : short {Private, Corporal, Sergeant or Lieutenant, Captain, Major}
6. What is a struct?

   - A structure is a value type.
7. List some differences between classes and structs.

   -  A class has all members private by default. A struct is a class where members are public by default.
   -  Class can create a subclass that will inherit parent's properties and methods, whereas Structure does not support the inheritance.
8. Are structs stored on the stack or on the heap? What about enums?

   - Structure instances are called *values* and live on the stack.
   - Enums are stored in both
9. . Review the documentation for the C# System.Int32 struct. List the fields. List the methods.

   -  Represents 32-bit signed integer(also termed as int data type) starting from range -2,147,483,648 to +2,147,483,647.
10. Declare a struct named DOD with four branches.

    -  Struct DOD {
    -  private string usmc, usn, usa, usaf;
    -  }
11. Why can’t you create a default constructor for a struct?

    - A struct is a value type and a value type must have a default value as soon as it is declared.
12. What is CIL? What does the CLR do to the CIL?

    - Pseudo-machine code called the Common Intermediate Language
    - When you compile a C# application, the compiler converts your C# code into a set of instructions using CIL



