
# Code Challenge 08: Merge Linked Lists
 - Merge two linked lists.
## Challenge
- Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
### Approach
- I created a base case that handled zipping two linked lists together while both linked lists current.next nodes were not null that that used a LL1 helper and a LL2 helper to save the .next data while the zip was happening.
- I then created two cases that handed how to zip together uneven lists once the main even zip had completed.
- I also handled cases where either one or the other of the input LL were empty or if both LL were empty.

### Efficiency
#### Space
O(n)
#### Time
O(n)

