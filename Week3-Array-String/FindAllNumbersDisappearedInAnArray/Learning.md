# Learnings from Array Problems

## 1. Find all Duplicates in an Array

This problem involves identifying all duplicate elements in an array. The key takeaways are:

- **Frequency Count Approach**: We can solve this problem by counting the occurrences of each number in the array. A hash map or array can be used to store the counts.
- **In-place Modifications**: Instead of using extra space, we can modify the array itself, by marking elements as visited, to avoid extra space overhead.
- **Sorting**: Sorting the array first can help in identifying duplicates by comparing adjacent elements.
- **Time Complexity**: This problem is often solved in O(n) time complexity by using hashing or by modifying the array in place with constant space, making it space-efficient.

## 2. Find All Numbers Disappeared in an Array

This problem involves finding all numbers that are missing from an array. The key takeaways are:

- **In-place Modification**: Similar to the previous problem, in-place modifications are crucial to solving this problem with constant space. The idea is to use the input array to mark the presence of elements.
- **Index Mapping**: Use the index to represent the presence of an element in the array. For example, if a number `x` is present, mark the index `x-1` in the array as visited.
- **Time Complexity**: The time complexity is O(n), as it involves iterating over the array and making constant time modifications to the array.
- **Handling Negative Numbers**: Ensure that modifications do not cause out-of-bound issues or unintended changes when dealing with negative numbers.

## General Concepts from Both Problems

- **Space Efficiency**: Both problems emphasize space-efficient solutions, especially by utilizing in-place modifications.
- **Array Traversal**: Most array-based problems require a careful traversal strategy to minimize time and space complexity.
- **Index-based Techniques**: Using the array indices to store or track data is a common pattern in array problems, reducing the need for additional data structures.
