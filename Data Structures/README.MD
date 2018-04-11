## Algorithm Analysis  

#### [Contents]():  

- [Introduction]()  


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
