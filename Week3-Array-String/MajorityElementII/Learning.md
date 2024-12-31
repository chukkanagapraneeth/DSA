# Generalized Algorithm for n / k (k = 3)

## Key Insights
1. The maximum number of elements that can appear more than \( \frac{n}{3} \) times in the array is \( k - 1 \), which in this case is \( 3 - 1 = 2 \).
2. Therefore, we only need to track two potential candidates and their counts.

## Algorithm Steps

### Initialization
- Declare four variables: `count1`, `count2`, `num1`, and `num2`.
  - `num1` and `num2` will store the two potential candidates.
  - `count1` and `count2` will store the respective counts of `num1` and `num2`.

### Step 1: Identify Potential Candidates
Iterate through the array and apply the following logic:

- If `nums[i] == num1`, increment `count1`.
- Else if `nums[i] == num2`, increment `count2`.
- Else if `count1 == 0`, assign `nums[i]` to `num1` and set `count1 = 1`.
- Else if `count2 == 0`, assign `nums[i]` to `num2` and set `count2 = 1`.
- Else, decrement both `count1` and `count2`.

At the end of this step, `num1` and `num2` will hold the two potential candidates that could appear more than \( \frac{n}{3} \) times.

### Step 2: Validate the Candidates
- Iterate through the array again to count the occurrences of `num1` and `num2`.
- Add `num1` to the result list if its count is greater than \( \frac{n}{3} \).
- Similarly, add `num2` to the result list if its count is greater than \( \frac{n}{3} \).

### Step 3: Return the Result
- Return the list of elements that appear more than \( \frac{n}{3} \) times.

## Implementation in C#
```csharp
public IList<int> MajorityElement(int[] nums) {
    int count1 = 0, count2 = 0;
    int num1 = 0, num2 = 0;

    // Step 1: Identify Potential Candidates
    foreach (int num in nums) {
        if (num == num1) {
            count1++;
        } else if (num == num2) {
            count2++;
        } else if (count1 == 0) {
            num1 = num;
            count1 = 1;
        } else if (count2 == 0) {
            num2 = num;
            count2 = 1;
        } else {
            count1--;
            count2--;
        }
    }

    // Step 2: Validate the Candidates
    count1 = 0;
    count2 = 0;

    foreach (int num in nums) {
        if (num == num1) count1++;
        if (num == num2) count2++;
    }

    List<int> result = new();

    if (count1 > nums.Length / 3) result.Add(num1.Value);
    if (count2 > nums.Length / 3) result.Add(num2.Value);

    // Step 3: Return the Result
    return result;
}
```

## Generalization for Any Fraction \( \frac{n}{k} \)

To generalize this algorithm for any \( \frac{n}{k} \):

1. The maximum number of potential candidates will be \( k - 1 \).
2. Use \( k - 1 \) variables to track the potential candidates and their counts.
3. Adjust the threshold for validation to \( \frac{n}{k} \).

### Algorithm Outline for \( \frac{n}{k} \)
1. Maintain \( k - 1 \) candidate elements and their respective counts.
2. In the first pass:
    - For each element in the array, either increment the count of an existing candidate or replace a candidate whose count becomes 0.
    - If all counts are non-zero, decrement all counts.
3. In the second pass:
    - Count the occurrences of each candidate.
    - Add a candidate to the result if its count exceeds \( \frac{n}{k} \).
4. Return the result list.

By applying this approach, you can efficiently find all elements appearing more than \( \frac{n}{k} \) times in \( O(n) \) time and \( O(1) \) space.



# Boyer-Moore Voting Algorithm: Key Learnings and Generalized Algorithm

## Key Learnings

### When to Use This Algorithm:
1. **Finding Elements Occurring More Than \( n/k \) Times**:
   - This algorithm is ideal when you need to find elements that appear more than \( \lfloor n/k \rfloor \) times in an array.
   - Common use cases include finding majority elements (e.g., \( n/2 \)), finding frequent elements (e.g., \( n/3 \), \( n/4 \), etc.).

2. **Space Optimization**:
   - The algorithm works in constant \( O(1) \) space, making it suitable for scenarios where memory usage is a constraint.

3. **Linear Time Complexity**:
   - The algorithm processes the array in \( O(n) \), making it highly efficient for large datasets.

### Where to Use This Algorithm:
1. **Majority Element Problems**:
   - Problems where elements need to appear more than \( n/2 \), \( n/3 \), or any fraction \( n/k \) times.

2. **Data Streams**:
   - Suitable for scenarios where data is streaming, and memory is limited.

3. **Voting Problems**:
   - Problems analogous to voting systems where "candidates" are selected or removed based on their counts.

### Key Characteristics of the Algorithm:
1. It keeps track of \( k-1 \) potential candidates when looking for elements that appear more than \( n/k \) times.
2. It performs two passes:
   - **First Pass**: Identify potential candidates.
   - **Second Pass**: Verify the actual counts of candidates.
3. It does not use any additional data structures (like dictionaries or hashmaps), ensuring \( O(1) \) space complexity.

---

## Generalized Boyer-Moore Algorithm for \( n/k \):

```csharp
using System.Collections.Generic;

public class Solution {
    public IList<int> FindMajorityElements(int[] nums, int k) {
        // Step 1: Initialize candidates and their counts
        int[] candidates = new int[k - 1];
        int[] counts = new int[k - 1];

        // Step 2: Identify potential candidates
        foreach (int num in nums) {
            bool found = false;

            // Check if the current number matches any candidate
            for (int i = 0; i < k - 1; i++) {
                if (candidates[i] == num) {
                    counts[i]++;
                    found = true;
                    break;
                }
            }

            if (!found) {
                // Check if there is an empty slot for a new candidate
                for (int i = 0; i < k - 1; i++) {
                    if (counts[i] == 0) {
                        candidates[i] = num;
                        counts[i] = 1;
                        found = true;
                        break;
                    }
                }
            }

            // If no match or empty slot, decrement all counts
            if (!found) {
                for (int i = 0; i < k - 1; i++) {
                    counts[i]--;
                }
            }
        }

        // Step 3: Verify the candidates
        int[] actualCounts = new int[k - 1];
        foreach (int num in nums) {
            for (int i = 0; i < k - 1; i++) {
                if (candidates[i] == num) {
                    actualCounts[i]++;
                }
            }
        }

        // Step 4: Collect results
        List<int> result = new List<int>();
        for (int i = 0; i < k - 1; i++) {
            if (actualCounts[i] > nums.Length / k) {
                result.Add(candidates[i]);
            }
        }

        return result;
    }
}
```

---

## Explanation of Generalized Algorithm:
1. **Input**:
   - Array of integers `nums`.
   - Integer `k`, representing the fraction \( n/k \).

2. **Initialization**:
   - Maintain an array `candidates` of size \( k-1 \) to store potential candidates.
   - Maintain an array `counts` of size \( k-1 \) to store counts of candidates.

3. **First Pass (Candidate Selection)**:
   - For each element in the array:
     - If it matches a candidate, increment the corresponding count.
     - If there is an empty slot, assign it as a new candidate with a count of 1.
     - If no match or empty slot, decrement all counts.

4. **Second Pass (Verification)**:
   - Count occurrences of each candidate in the array.
   - Validate candidates by checking if their count exceeds \( n/k \).

5. **Output**:
   - Return the list of validated candidates.

---

## Example:
### Input:
```plaintext
nums = [1, 2, 3, 1, 2, 1, 1], k = 4
```

### Process:
1. **First Pass (Identify Candidates)**:
   - Candidates: `[1, 2, 3]`
   - Counts: `[2, 1, 1]` (after processing the entire array).

2. **Second Pass (Verify Candidates)**:
   - Candidate `1` appears 4 times, \( 4 > \lfloor 7/4 \rfloor \).
   - Candidate `2` appears 2 times, \( 2 \leq \lfloor 7/4 \rfloor \).
   - Candidate `3` appears 1 time, \( 1 \leq \lfloor 7/4 \rfloor \).

### Output:
```plaintext
[1]
```

---

## Complexity Analysis:
- **Time Complexity**: \( O(n) \)
  - First pass: \( O(n) \).
  - Second pass: \( O(n) \).
- **Space Complexity**: \( O(1) \)
  - Uses fixed space for candidates and counts arrays of size \( k-1 \).


### Extended Boyer Moore's Voting Algorithm - MY NOTES

### The order of if else matters here
## this will not work for [2,2] as the output will be [2,2] instead of [2] because num1 = 2 and num2 = 2;
foreach(int i in nums)
{
    if(count1 == 0)
    {
        num1 = i;
        count1++;
    }
    else if(count2 == 0)
    {
        num2 = i;
        count2++;
    }
    else if(i == num1)
    {
        count1++;
    }
    else if(i == num2)
    {
        count2++;
    }
    else
    {
        count1--; count2--;
    }
}

## To Avoid duplicates, we should check if the current num is equal to num1 and num2 then we check if count1 and count2 is 0 
foreach(int i in nums)
{
    if (i == num1)
    {
        count1++;
    }
    else if (i == num2)
    {
        count2++;
    }
    else if(count1 == 0)
    {
        num1 = i;
        count1++;
    }
    else if(count2 == 0)
    {
        num2 = i;
        count2++;
    }
    else
    {
        count1--; count2--;
    }
}

