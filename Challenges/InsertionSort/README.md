
# Code Challenge: Insertion Sort
 - Insertion Sort
## Challenge
- Write a function for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.
### Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

- Write at least three test assertions for each method that you define.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
### Approach

- I created the InsertionSort method.
  - Input = int[] array
  - Output = int[] array
  - I then created a for loop that will iterate through each element in the input array.
    - I initially set a value to int j to zero so that j won't go out of bounds when the loop starts.
    - I then created a conditional that will set j to i - 1 once i > 0.
    - I then set int target to array[i] so that I can compare its value to previous array values.
    - I then set int previous to array[j]
    - I then created a while loop inside of the for loop that runs while target is less than previous and j is greater or equal to zero.
      - I then set array[j] to the target int
      - I set the array[j+1] to the previous int
      - Then I created a conditional where if j > 0 then int previous gets set to array[j-1].
      - Then j reduces by 1 and the while loop restarts.
  - I then return the array




### Efficiency
#### Space
O(n)
#### Time
O(n^2)

