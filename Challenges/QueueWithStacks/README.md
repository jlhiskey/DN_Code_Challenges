
# Code Challenge 11: Merge Linked Lists
 - Implement a Queue using two Stacks.
## Challenge
- Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement the standard queue interface, but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:
  - Enqueue(int value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
  - Dequeue(int value) which extracts a value from the PseudoQueue, using a first-in, first-out approach.
- The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- I created the PseudoQueue class which contains two stacks (stackOne and stackTwo) and a constructor that will force user to add a single node to the PsuedoQueue when instantiating.
- I then created the Enqueue method which takes input value and runs the push method of stackOne and adds a node to the top of stack one with input value.
- I then created the Dequeue method which pops all of the nodes from stack one and pushes those values onto stackTwo. It then pops the first value of stackTwo onto a helper node (current) to store that node. It then pops all of the values off of stackTwo and pushes them back onto stackOne.  It then returns current.

### Efficiency
#### Enqueue method
#### Space
O(1)
#### Time
O(1)

#### Dequeue method
#### Space
O(1)
#### Time
O(n)

