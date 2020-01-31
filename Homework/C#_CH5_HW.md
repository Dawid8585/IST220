## --DAWID PERKOWSKI
## --FILE : HW_05



1. What is a compound assignment operator? How does it work?
- Assignment variables can be used to change the value of a variable and can be combined with any arithmetic operator with the assignment operator. They are can be used to append one string to another and update numeric values.

2. List all the compound assignment operators.
- /,*,--,++,%

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.
-  variable +=5;  : 0 + 5 
- variable -=50;  50 - 0
4. How long does a while loop run?
- A while loop iterates through the file one line at a time until there are no more lines available.

5. What is an iteration variable? (Not in book)
- It's a fancy way to say loop. Specifically for "for each" statements.

6. What happens if you don't change the loop variable in the body of the while loop block?
- You can possibly run into the common mistake of letting the loop run forever. The 'i' variable controls how often it runs

7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?
- The three parts for a for loop are initialization, boolean expression, and code that updates the control variable. You can omit certain parts of the for loop. By omitting Boolean expression, it defaults to true, so the statement runs forever.

8. How do you guarantee that a loop runs at least once?
- You guarantee that a loop runs at least once by making sure that the boolean expression evaluates to true

9. What does the break statement do?
- When the break statement is encountered inside a loop, the loop is immediately terminated and program control resumes at the next statement following the loop.

10. What does the continue statement do?
- The continue statement causes the program to perform the next iteration of the loop immediately.

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An infinite loop is a loop without an update variable that in effect runs forever. As you will see, these kinds of loops are written intentionally to perform various kinds of tasks.
- Yeah for an application that needs to run for a while, maybe a advertisement of sorts, or GIF.
