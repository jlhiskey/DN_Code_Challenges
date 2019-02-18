
# Code Challenge 17: Breadth First Traversal
 - Breadth-first Traversal.
## Challenge
- Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach; print every visited node’s value.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- I first brought in classes: BinaryTree, Node, Queue and QNode
  - I then modified QNode to have a payload of Node and modified Queue.Peek() to return Node instead of Qnode.
- I then created the method BreadthFirstTravesal(BinaryTree tree)
  - Inside of the method I created a new list that will capture the visted nodes values.
  - I then created a new queue which will store the nodes of the tree until they can be stored in the list and printed.
  - I then added tree.Root to the queue.
  - I then created a while loop that runs while the queue has nodes in it.
    - I then pull out my first node from the queue and add it to my list and print its value.
    - I then check if there is a left node.
      - If there is I add that node to the queue.
    - I then check if there is a right node.
      - If there is I add that node to the queue.
    - I then dequeue my queue so that when the while loop restarts I have my next value to work with.
  - After the while loop finished I return the list of captured values.
  
### Efficiency
#### Space
O(w)
#### Time
O(n)

## Whiteboard
![whiteboard image](./assets/Whiteboard.jpg)

## API
### BreadthFirstTraversal Required Classes
- BinaryTree class
- Node class
- Queue class
- Queue Node class
