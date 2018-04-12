## Algorithm Analysis  

A summary of ...

> Microsoft: DEV204.3x  
> Algorithms and Data Structures in C#

... course section.

#### [Contents]():  

- [Introduction]()
- [Algorithm Analysis]()
- [Big O Asymptotic Notation]()  


-----

### [Introduction]()  

It is the act of evaluating the rate at which an algorithm will operate based on the range of inputs.   

For example,  

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

### [Algorithm Analysis]()  

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

**Algorithm Analysis becomes important when**:

**A. The size of the input is significantly large**.   

Procedure for Binary Search:  

1. Get the left and right indexes for the entire array.  
2. Calculate the middle.  
3. Perform the comparison.  
4. If not found, half the array and then repeat 1 to 3. Otherwise, return the search term.

Procedure for Linear Search:  

1. Compare at index zero.  
2. If not found, increment to the next index. Otherwise, return the search term.   

Linear Search will be more efficient/faster than Binary Search for small input sizes up to a certain point.

**B. To know at what point of an input size that an algorithm would be best suited for**   

Performing the analysis saves from using trial and error with the [steps mentioned here]().  

**Before proceeding with the analysis**:  

1. Know what operations take place.  
2. Know the amount of time an operation takes.    

### [Big O Asymptotic Notation]()  

Also known as the _Bachmann-Landau Notation_, named after Paul Bachmann and Edmond Landau.   

On a concise context:  

Big O is a mathematical notation used in algorithm analysis. It is used in determining the "_limiting behaviour_" of the function/usage that applies to an algorithm.  

It is used to classify algorithms according to _limits on runtime or input size_. This can show whether or not an algorithm is not suitable. There may be several reasons, either its performance will take too long to complete and/or is not capable of handling the input size efficiently.  

** O( _ ) **

This notation describes the performance of an algorithm.   

**_** could be any expression describing the number of iterations relative to the growth of the input size.  

**This graph below shows several common performance expressions i.e. time complexities**:  

![Image from edX](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/14ecb5fd6549a34e1b4ab327831b088c/asset-v1:Microsoft+DEV204.3x+4T2017+type@asset+block/Big_O_Chart.PNG)  

Graph Legend:

| T(n) | time       | y-axis |
| :--: | :--------: | :----: |  
| n    | input size | x-axis |

The plots on the graph explained:

For example, the line 100n is a linear plot. That means that as the size of n increases, the time required goes up in a linear fashion. This is because the only operation in the function takes a preset amount of time so that preset time is multiplied by the size of n.

The worst case scenario in this graph is the function 2n. That is to say that we raise 2 to the power of the value contained in n. As you can see, for smaller values, it is a relatively shallow curve until we hit about 8 on the X axis, at which point the time jumps significantly.

**The following table shows how _time_ grows in relation to how _n_ increases**:

![Big O Expressions](https://www.cpp.edu/~ftang/courses/CS240/lectures/img/alg-tab.jpg)  

**A list of various time complexities**:  

![A List of Different Time Complexities ](https://he-s3.s3.amazonaws.com/media/uploads/c950295.png)  

**Complexities in graph form**:

![Big O Expression Graph Form](http://blog.benoitvallon.com/img/2016-03-12-sorting-algorithms-in-javascript/big-o-complexity.png)  
