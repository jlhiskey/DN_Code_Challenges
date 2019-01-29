
# Code Challenge 16: FizzBuzz
 - Conduct “FizzBuzz” on a tree while traversing through it. Change the values of each of the nodes dependent on the current node’s value
## Challenge
- Write a function called FizzBuzzTree which takes a tree as an argument.
- Without utilizing any of the built-in methods available to your language, determine weather or not the value of each node is divisible by 3, 5 or both, and change the value of each of the nodes:
  - If the value is divisible by 3, replace the value with “Fizz”
  - If the value is divisible by 5, replace the value with “Buzz”
  - If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
- Return the tree with its new values.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- I modified the Node and BinaryTree class to handle no int values.
- I then created the FizzBuzzTree method that takes a BinaryTree as an input.
  - Within the method I created 3 helper methods:
    - void HelperFizzBuzz(Node node)
      - Conducts a pre-order traversal but runs CompareValue(ParseStringInt(Node)) before recursively traversing the tree.
    - int ParseStringInt(Node)
      - Converts a nodes value into an integer.
    - string CompareValues(int)
      - Compares an integer to a a series of if statements and returns string "FizzBuzz" if integer is divisible by 3 and 5 wholey, "Fizz" if integer is divisible by 3 and "Buzz" if integer is divisible by 5.
    - I then return the modified tree.


### Efficiency
#### Space
O(h)
#### Time
O(n)

## Whiteboard
![whiteboard image](./assets/Whiteboard.jpg)
- Whiteboard Author: Andrew Hinojosa

