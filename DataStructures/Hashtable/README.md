
# Lab 05: Linked Lists
 - Implement a Hashtable
## Challenge
Implement a Hashtable with the following methods:

- Add: Takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- Get: Takes in the key and returns the value from the table.
- Contains: Takes in the key and returns a boolean, indicating if the key exists in the table already.
- Hash: Takes in an arbitrary key and returns an index in the collection.
- STRETCH Remove: Takes in a key and remove the key value pair from the table and handles collisions.

## Approach & Efficiency
### Approach
HashNode Class
- Attributes
  - int Key
  - object Value (so that data can be generic)
  - HashNode Next (to handle collisions)
- Constructor method
  - input = string key and object value
  - Creates a new HashNode with a Key = key, Value = value and Next = null
 
Hashtable Class
  - Attributes
    - int Container (Overall Capacity of the Container)
    - int Size (Total amount of data present in hash table)
    - HashNode[] Storage (Actual data container)
  - Constructor method
    - input = integer representing how large the Storage will be.
    - Creates an array of HashNodes using the input to determine size.
  - Hasher method
    - input = string key
    - output = int index
    - Takes the input string and adds the total ASCII char values of each character in the string together.
    - It then takes that sum and multiplies it by 699(Prime Number. Thanks for the hint Amanda). 
    - It then takes that value finds its modulo using the Container. value % Container.
    - It then converts the value to an integer and returns it. 
    - The return will eventually be the index that a key value pair will be placed in.
  - Add method
    - input = string key and Object value
    - First thing the method does it run the Contains(key) method to check if the key already exists within the hashtable.
    - If the hashtable does not contain that key then a new HashNode will be created with Key = key and Value = value.
    - The Hasher method is then fed the key and and the index is determined.
    - Then I check to see if there are any possible collisions. If Storage[index] == null then I add my new HashNode to that position.
    - If a collision is detected then I iterate through the .Next values till I find the end and add my HashNode there. (I probably could have saves some time by just inserting at head...)
    - I then increase the int Size by 1 to keep track of added data.
  - Get method
    - input = string key 
    - Output = object value
    - First thing the method does it run the Contains(key) method to check if the key already exists within the hashtable.
    - If it cant find the key the method will return null.
    - Else  
    - The Hasher method is then fed the key and and the index is determined.
    - Then I check to see if there are any possible collisions. If Storage[index] == key then life is easy and I just return the value.
    - If I got unlucky and my target HashNode is in a collision then I have to iterate through the HashNode.Next until I find the target then I return the retreived HashNode's value.
  - Contains method
    - input = key
    - output = bool
    - The Hasher method is fed the key and and the index is determined.
    - If the Storage at index is null then we return false
    - If the Storage at index is not null and equals the key then we return true.
    - If the Storage at index is not null and does not equal the key then I have to check if it is stored within that indexes collision structure. 
    - I then iterate through the collision and if the key is found then I return true else the method defaults to a false return.
  - Remove method
    - input = key
    - First thing the method does it run the Contains(key) method to check if the key already exists within the hashtable.
    - If the hashtable does contain that key.
    - The Hasher method is then fed the key and and the index is determined.
    - Then I check to see if there are any possible collisions. If Storage[index] == key Storage[index].Next == null then life is easy and I just set Storage[index] to null.
    - If I get kind of lucky and there is a collision but the first value in the collision matches my key then I set Storage[index] to Storage[index].Next
    - If I am unlucky then I iterate through the collision structure until I find the matching key then remove that value from the linked list and set its Next value to the preceding HashNodes .Next value.

### Efficiency
##### Space
O(n)
#### Add method
##### Time
Best Case O(1) Medium Case O(collisions) Worst Case O(n)
#### Get method
##### Time
Best Case O(1) Medium Case O(collisions) Worst Case O(n)
#### Contains method
##### Time
Best Case O(1) Medium Case O(collisions) Worst Case O(n)
#### Remove method
##### Time
Best Case O(1) Medium Case O(collisions) Worst Case O(n)

## API
### Class Hashtable Required Classes
- Hashtable requires HashNode class.

