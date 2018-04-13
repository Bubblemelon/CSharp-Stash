## Algorithm Analysis  

A summary of ...

> Microsoft: DEV204.3x  
> Algorithms and Data Structures in C#

... course section.

#### [Contents]():  

- [Introduction]()
- [Algorithm Analysis]()
- [Big O Asymptotic Notation]()
- [Analysis Examples]()


-----

## [Introduction]()  

It is the act of evaluating the rate at which an algorithm will operate based on the range of inputs.   

**e.g.**

Binary Search is faster than Linear Search. This may not always be the case:  

| Input   | Algorithm   | Rate  |
| ------  | ----------- | ----- |
| First value in Array | Linear Search | Faster than Binary |
| Last value in Array  | Linear Search | Very slow, slower than Binary |

**Steps for evaluating an algorithm**

Determine:  
  1. the size of the input   
  2. the time it takes to perform a single comparison in the search; _the comparison of values is a fixed amount of time_   

Therefore, the larger the input, the more time it takes for the search.  

**Types of Cases**

| Cases      |  Examples  |
| ---------- | ---------- |
| Best Case  | Linear Search: If the search term on the first comparison |
| Average Case| Linear Search: If the search term was around in the middle of the array |
| Worst Case | Linear Search: If the search term was found at the end of the array i.e. The maximum amount of time that the search could take |

Normally, the average case is used to determine the algorithm that will produce the most reasonable time based on expected input sizes.  

## [Algorithm Analysis]()  

To determine the performance of an algorithm:

1. Implement each algorithm.  
2. Run it on the intended computing platform.  
3. Measure completion times for each of the algorithms.  
4. Record the times.  
5. With the recorded times, determine the case type that an algorithm falls into based on the search term, and its input size that it will be searching through.

**Note**:    

The above steps are _time consuming_ and **not efficient** and will need to be repeated for different inputs and search data situations.   

Algorithm analysis can be a futile task based on computing hardware resources and is time costly for the programmer.  

**e.g.** if the time performance for linear search and binary search were compared:  

On a modern computer CPUs with multiple cores and lots of memory -  _most input sizes will produce times so close that they are not detrimental to a program's operation and speed_.  

### Algorithm Analysis becomes important when:

**A. The size of the input is significantly large**.   

Procedure for Binary Search:  

1. Get the left and right indexes for the entire array.  
2. Calculate the middle.  
3. Perform the comparison.  
4. If not found, half the array and then repeat 1 to 3. Otherwise, return the search term.

##### [Procedure for Linear Search](#procedure-for-linear-search):  

1. Start comparing at index zero.  
2. If not found, increment to the next index. Otherwise, return the search term.   

Linear Search will be more efficient/faster than Binary Search for small input sizes up to a certain point.

**B. To know at what point of an input size that an algorithm would be best suited for**   

Performing the analysis saves from using trial and error with the [steps mentioned here]().  

**Before proceeding with the analysis**:  

1. Know what operations take place.  
2. Know the amount of time an operation takes.    

## [Big O Asymptotic Notation]()   

Also known as the _Bachmann-Landau Notation_, named after Paul Bachmann and Edmond Landau.   

On a concise context:  

Big O is a mathematical notation used in algorithm analysis. It is used in determining the "_limiting behaviour_" of the function/usage that applies to an algorithm.  

It is used to classify algorithms according to _limits on runtime or input size_. This can show whether or not an algorithm is not suitable. There may be several reasons, either its performance will take too long to complete and/or is not capable of handling the input size efficiently.  

### O( _ )  

This notation describes the performance of an algorithm.   

**_** could be any expression describing the number of iterations relative to the growth of the input size.  

**This graph below shows several common performance expressions i.e. time complexities**:  

![Image from edX](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/14ecb5fd6549a34e1b4ab327831b088c/asset-v1:Microsoft+DEV204.3x+4T2017+type@asset+block/Big_O_Chart.PNG)  

Graph Legend:

| T(n) | time       | y-axis |
| :--: | :--------: | :----: |  
| n    | input size | x-axis |

Two lines on the graph briefly explained:

_100n_ is a linear expression. As the size of _n_ increases, performance time linearly increases. It is the time of all the steps in the an algorithm (one iteration) multiplied by _n_.

The expression _2^n_ would be considered the worst case among the other expressions on the graph. Since 2 is raised to the power of _n_. Some where between 5 to 10 of value n, approx. at 8 on the x-axis, the time of of _2^n_ increases dramatically.

The balance point:

The points at which two graph lines intersect. To compare different algorithms.

**e.g.** Looking at _100n_ and _2^n_ again, the balance point is about when _n = 10_.

_2^n_ performs better when _n_ is between 0 to 10. While _100n_ performs better than _2^n_ at any value of _n_ after 10. Additionally, any time complexity expression will perform better than _2^n_ as long as it is equal or faster than _100n_.  

**The following table shows how _time_ grows in relation to how _n_ increases**:

![Big O Expressions](https://www.cpp.edu/~ftang/courses/CS240/lectures/img/alg-tab.jpg)  

**A list of various time complexities**:  

![A List of Different Time Complexities ](https://he-s3.s3.amazonaws.com/media/uploads/c950295.png)  

**Complexities in graph form**:

![Big O Expression Graph Form](http://blog.benoitvallon.com/img/2016-03-12-sorting-algorithms-in-javascript/big-o-complexity.png)  

## [Analysis Examples]()

Looking at the time complexity of an algorithm allows the comparison of different algorithms. Finding the actual performance time completion between two algorithms isn't necessary.

Analysing Bubble Sort, Selection Sort and Linear Search.

**Bubble Sort**:

<table>
  <tbody>
    <tr>
      <th>Procedure</th>
      <th>Procedure Explained</th>
      <th>Analysis Explained</th>
    </tr>
    <tr>
      <td>
        <ol>
          <li>
            Starting from index 0, compare adjacent elements.
          </li>
          <li>
            Check if right element is larger than left element. If true then swap.
          </li>
          <li>
            Repeat steps 1 and 2, by incrementing to the next element until the last element on the array. (There are n-1 checks)
          </li>
          <li>
            Check after each iteration if a swap was made. If none, then n elements are sorted.
          </li>
        </ol>
      </td>
      <td>
        Nested loops:
        <ul>
          <li>
            Outer loop: Makes sure that the array is sorted before exiting.
          </li>
          <li>
            Inner loop: Iterates from the beginning to the end of the array. Responsible for doing the checks and then swaps.
          </li>
        </ul>
        The comparison and the swaps takes a fix amount of time.
        <br/><br/>
        An iteration of the entire array is done when the outer loop iterates.
      </td>
      <td>
        The time complexity of a Bubble Sort is <code>O(n^2)</code>.
        <br/><br/>
        Every time the outer loop iterates, a complete array iteration in the inner loop happens.
        <br/><br/>
        i.e. an iteration of the entire array is done when the outer loop iterates.
      </td>
    </tr>
  </tbody>
</table>

**Selection Sort**:  

<table>
  <tbody>
    <tr>
      <th>Procedure</th>
      <th>Procedure Explained</th>
      <th>Analysis Explained</th>
    </tr>
    <tr>
      <td>
        <ol>
          <li>
            The current element is compared with all other elements (except itself) in the array, starting from index 0.
          </li>
          <li>
            A swap is made if the comparing element (the minimum in the unsorted portion) is smaller than the current, these two switch index positions.
          </li>
          <li>
            The sorted port of the array grows from index 0 up to the current element being compared.
          </li>
          <li>
            Steps 1. and 2. are repeated until the iteration reaches the end of the array.
          </li>
        </ol>
      </td>
      <td>
        Nested loops:
        <ul>
          <li>
            Outer loop: Keeps track of the current element in the array.
          </li>
          <li>
            Inner loop: Compares the current element with all other elements in the array by iterating through the unsorted portion and finds the minimum in the unsorted portion. Does the swaps if the minimum is smaller than the current.
          </li>
        </ul>
      </td>
      <td>
        The time complexity of a Selection Sort is <code>O(n^2)</code>.
        <br/><br/>
        This is the same as Bubble Sort due to the loop and its nest loop in the Selection Sort procedure.
      </td>
    </tr>
  </tbody>
</table>

**Linear Search**:  

[Referring to the Linear Search procedure]([Procedure for Linear Search](#procedure-for-linear-search):

Receiving the search term and accessing the current index does not require processing power, this is at a constant time of `O(1)`.  

If the first element of the array happens to be the search term, then its time complexity would be `0(1)` since the algorithm did not have to increment and iterate to the next element. This is considered the best case.    

Making the comparison and incrementing `i` (the index number holder), _does require processing power_ and takes a fixed certain amount of time.  

The time complexity for a Linear Search is `O(n)` because the procedure is handled by a loop that iterates through the entire array from index 0 to the last element i.e. the size of _n_.  

`0(n)` is the time complexity for its worst case. This would apply if the search term was at the end of the array, meaning that the iteration would need to iterate a total of size _n_.  
