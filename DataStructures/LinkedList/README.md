
# Lab 05: Linked Lists
 - Implement a Singly Linked List Data Structure
## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
  - This object should be aware of a default empty value assigned to head when the linked list is instantiated.
  - Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
  - Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
  - Define a method called print which takes in no arguments and outputs all of the current Node values in the Linked List.
- At no time should an exception or stack trace be shown to the end user. Catch and handle any such exceptions and return a printed value or operation which cleanly represents the state and either stops execution cleanly, or provides the user with clear direction and output.
- Be sure to follow your language/frameworks standard naming conventions (e.g. C# uses PascalCasing for all method and class names).    

## Approach & Efficiency
### Approach
- I created the node class first and then built the linked list class.
- I then created the InsertAtHead method within the linked list class.
    - Checks value of a linked list and adds head to current.next then sets current node as head.
- I created the Append method which will either add the new node at the head of an empty list or it will interate until it reaches the end of the list and then will add the new node at the end of the list.
- I created the InsertBefore method which will take in a target node value and a new node value. It will then check the linked list to find the target node and if it finds the target node it will then add the new node with the new value before that target node and then will reattach the existing data to the list.
- The insert after method works the same as the InsertBefore method but will instead add the new node with the new value after the target node.
- I then created the Includes method which interates through the linked list and returns true if if input value is equal to current.value.
-I then created a print method and decided that I would all a size property to the linked list class that would keep track of how big the linked list was so the when you were printing it would add the values to an array where Head = index 0. 
### Efficiency
#### InsertAtHead method
#### Space
O(1)
#### Time
O(1)
#### Includes method
#### Space
O(1)
#### Time
O(n)
#### Print method
#### Space
O(n)
#### Time
O(n)
#### Append method
#### Space
O(n)
#### Time
O(n)
#### InsertBefore method
#### Space
O(n)
#### Time
O(n)
#### InsertAfter method
#### Space
O(n)
#### Time
O(n)
## API
### Class LList Required Methods
- LList requires Node class to be able to add nodes into the list.

