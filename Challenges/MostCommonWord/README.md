
# Extra Credit 3: Most Common Word
 - Determine the most common word in a book.
## Challenge
- Ask the candidate to write a function that determines the most common word in a book.
- Spaces don’t count, and words are not case sensitive (i.e. Cat, CAT, and cat are all the same)
- Don’t concern yourself wth punctuation.
- The function created should take in a string as an argument.
- The word with the highest counter at the end is the returned word.
- Edge Cases
  - It is possible to have words show up the same amount of times as others, In this case, return the first occurance (i.e. both “dog” and “cat” show up twice -> return “dog”);
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach
- I created the method string MostCommonWord(string book)
  - I then split the input book into an array of words using the " " as split criteria.
  - I then created a hashtable called wordTracker with 1024 buckets since assesing collision storage is difficult when you have to modify a value.
  - I then created a for loop that interates through the word array.
    - If wordTracker contains the word then it will be pulled out of storage and its counter will be increased by one then the counter will be compared to the highestCounter. 
      - If the counter is higher then the highestCounter then mostCommonWord will become that word and the highestCounter will become the counter.
      - I then update the counter in the wordTracker
    - If the wordTracker doesn't contain the word then I add it and set its counter to 1.
    - I then run a check to see if highestCounter is equal to 0. 
      - If counter is 0 I add the word as the most common word and set the highestCounter to 1. (This handles a book being full of only unique words so that you will still get a proper return)
  - I then return mostCommonWord
    
### Efficiency
#### Space
O(n)
#### Time
O(n)

## API
### MostCommonWord Required Classes
- HashTable class
  - HashNode class