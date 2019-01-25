
# Lab 10: Stacks and Queues
 - Implement a Tree
## Challenge
- Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
- Create a BinaryTree class
  - Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
//------------------------------------------------------------------
- Create a Queue class that has a top property. It creates an empty queue when instantiated.
  - This object should be aware of a default empty value assigned to front when the queue is created.
  - Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.
  - Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node’s value.
  - Define a method called peek that does not take an argument and returns the value of the node located in the front of the queue.
- At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.
- Be sure to follow your languages best practices for naming conventions.

## Approach & Efficiency
### Approach
- I created the Node class.
  - Properties: Value and Next
  
- Then I built the Stack class.
  - I decided to add a Size property that keeps track of total number of nodes in the stack. This will allow you to check for size later on when you go to pop a value so that you dont have to worry about exceptions.
  - I created a constructor method that allowed a user to create a new stack with or without a node using an overloaded constructor.
  - I then created a Push method which adds a new node with input value onto the stack and adds +1 to the Size of the stack and then returns the node from the stack.
  - I then created the Pop method which will check the size of the stack and return null if the size is zero else it will remove the youngest node in the stack and return it.
  - I then created the Peek method which will return the youngest node in the stack.
  - I then created the GetSize method that returns the total number of nodes in the stack.
  
- Then I built the Queue class.
  - I decided to add a Size property that keeps track of total number of nodes in the queue. This will allow you to check for size later on when you go to dequeue a value so that you dont have to worry about exceptions.
  - I created a constructor method that allowed a user to create a new queue with or without a node using an overloaded constructor.
  - I then created a Enqueue method which adds a new node with input value onto the end of the queue and adds +1 to the Size of the queue and then returns the node from the queue.
  - I then created the Dequeue method which will check the size of the queue and return null if the size is zero else it will remove the oldest node in the stack and return it.
  - I then created the Peek method which will return the oldest node in the stack.
  - I then created the GetSize method that returns the total number of nodes in the queue.

### Efficiency
#### Stack.Push and Queue.Enqueue methods
#### Space
O(1)
#### Time
O(1)
#### Stack.Pop and Queue.Dequeue methods
#### Space
O(1)
#### Time
O(1)
#### Stack.Peek and Queue.Peek methods
#### Space
O(1)
#### Time
O(1)
#### Stack.GetSize and Queue.GetSize methods
#### Space
O(1)
#### Time
O(1)

## API
### Class Stack and Queue Required Methods
- Both classes require Node class to be able to add nodes to the structures.

