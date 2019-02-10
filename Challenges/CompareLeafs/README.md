
# Extra Credit 2: Compare Leaves
 - Find the number of leaves between two binary trees.
## Challenge
- ou are working with a file structure with only at most 2 files or folder. Each file directory has either one or two folders/files.

Comparing two file different file directories, create a method that takes in 2 directory structures and compares both and determines whether or not they have the same number of individual files.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- Since I didn't need to modify my Binary Tree I brought in my preexiting Binary Tree and Node class as a dependency.
- I then created the method bool CompareLeaves(BinaryTree treeOne, BinaryTree treeTwo)
  - I then split off the Root of the trees into a new Nodes called rootOne and rootTwo.
  - I then check to see if the input trees have Nodes and return if one or both trees are null.
  - I then created two int variables called leafCounterOne and leafCounterTwo that will keep track of discovered leaves.
  - I then created 2 helper methods within CompareLeaves. 
    - void HelperOne(Node helperRootOne)
      - Runs a depth first traversal and adds too leafCounterOne if a leaf is found.
    - void HelperTwo(Node helperRootTwo)
      - Runs a depth first traversal and adds too leafCounterTwo if a leaf is found.   
  - I then call HelperOne(rootOne)
  - I then call HelperTwo(rootTwo)
  - I then compare leafCounterOne to leafCounterTwo.
    - If equal return true.
    - else return false
    
### Efficiency
#### Space
O(h)
#### Time
O(n)

## API
### FindMaxValue Required Classes
- BinaryTree class
- Node class