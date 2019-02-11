
# Snow Day Challenge: Calculate Height and (STRETCH) Level of Binary Tree
 - Caluculate the height and level of a binary tree.
## Challenge
-Implement a method with the following signature int CalculateBinaryTreeHeight(Node root) that calculates the height of a binary tree.
- Once you calculate the height of a tree, write a similar function to calculate the number of levels for a tree.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- Since I didn't need to modify my Binary Tree I brought in my preexiting Binary Tree and Node class as a dependency.
- I then created the method int CalculateBinaryTreeHeight(BinaryTree tree)
  - I then split off the Root of the tree into a new Node called root.
  - I then check to see if the input tree has any Nodes and return 0 if the tree is empty.
  - I then created an int variable called height.
  - I then created a helper method within CalculateBinaryTreeHeight. 
    - void HelperCalculateBinaryTreeHeight(Node helperRoot)
      - Runs a depth first traversal with two base cases. If a node is null it will return -1. If the node is a leaf it will return 0.
      - I then call HelperCalculateBinaryTreeHeight recursively and set an integer called leftChildHeight to the root.Left recursive call.
      - I then call HelperCalculateBinaryTreeHeight recursively and set an integer called rightChildHeight to the root.Right recursive call.
      - After leftChildHeight and rightChildHeight have been populated I then compare the two height and return the largest of the two with a modifier of +1 to take into account the node that the method is being called from.
    
  - I then set height to HelperCalculateBinaryTreeHeight(root)
  - I then return height.
- I then created the method int CalculateBinaryTreeLevel(BinaryTree tree) 
  - I then check to see if the input tree has any Nodes and return 0 if the tree is empty.
  - I then call CalculateBinaryTreeHeight(tree) and simply add 1 to that result since at tree.root the height would be 0 and the level would be 1. 
    
### Efficiency
#### Space
O(h)
#### Time
O(n)

## API
### FindMaxValue Required Classes
- BinaryTree class
- Node class

## Whiteboard
![whiteboard image](./assets/Whiteboard.jpg)