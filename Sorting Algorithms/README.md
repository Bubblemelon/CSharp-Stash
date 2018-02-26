# Sorting Algorithms

#### Contents:

- [Bubble Sort](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#bubble)  
- [Insertion Sort](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#insert)  
- [Selection Sort](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#select)  


### [:o:](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#bubble) [BubbleSort.cs](https://github.com/Bubblemelon/algorithms/blob/master/Sorting%20Algorithms/BubbleSort.cs)  

<table style="width:100%">
  <tr>
    <td colspan="2" align="center"><code>BubbleSort</code> Class
    </td>
  </tr>
  <tr>
    <td rowspan="2" nowrap><code>bubblesorting( int[] numbers )</code></td>
    <td align="left">
        This function takes an array of unsorted integers.
        Returns a sorted array in ascending order.
        <br/>
        <br/>
        For a descending order refer to <a href="https://github.com/Bubblemelon/Ruby-Stuff/blob/master/ruby%20practice/bubblesort.rb">bubblesort.rb</a>
    </td>
  </tr>
  <tr>
    <td>
    <b>The Recipe:</b>
    <br/>
    <br/>
    This algorithm compares two elements at a time (index[0] is compared with index[1] and then index[1] is compared with index[2] and so forth) as it moves to the end of the array.
    <br/>
    <br/>
    The smaller element is moved the left side of the larger element (swaps places). This keeps iterating until there are no more swaps.
    <br/>
    <br/>
    <a href="https://www.youtube.com/watch?v=HJynyWnpf-o">Bubble Sort Video</a>
    </td>
  </tr>
</table>

### [:o:](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#insert) [InsertionSort.cs](https://github.com/Bubblemelon/algorithms/blob/master/Sorting%20Algorithms/InsertionSort.cs)

<table style="width:100%">
  <tr>
    <td colspan="2" align="center"><code>InsertionSort</code> Class</td>
  </tr>
  <tr>
    <td rowspan="2" nowrap><code>insertsort1( int[] numbers )</code></td>
    <td align="left">
        This function takes an array of unsorted integers.
        <br/>
        Returns a sorted array in ascending order.
        <br/>
        <br/>
        <i>This is the <a href="https://www.geeksforgeeks.org/insertion-sort/">commonly accepted implementation</a>.</i>
    </td>
  </tr>
  <tr>
    <td align="left">
      <b>The Recipe:</b>
      <br/>
      <br/>
      This algorithm starts by comparing the second element at index [i] (as the current) with its previous element(s) at index [j-1], where <b>i</b> = 1 and <b>j</b> = <b>i</b>.
      <br/>
      <br/>
      As the iteration moves to the end of the array: The current element is checked with all its previous elements.
      <br/>
      <br/>
      The insertion is made when one of the previous elements is found to be larger than the current. The larger element is inserted at the current element position (replacing the current value). Subsequent previous elements larger than the current is inserted (after it).
      <br/>
      <br/>
      Lastly, current is inserted at the position to the right of a previous element that is smaller than the current.
      <br/>
      <br/>
      The sorting is finished when the iteration reaches the last element in the array.
      <br/>
      <br/>
      <a href="https://www.youtube.com/watch?v=juf0OL0hYxY">Insertion Sort Video</a>
    </td>
  </tr>
  <tr>
    <td rowspan="2" nowrap><code>insertsort( int[] numbers )</code></td>
    <td align="left">
        Same purpose as <code>insertsort1( int[] numbers )</code>.
        <br/>
        <br/>
        <i>This is of my own implementation that uses an ArrayList, with the following functions <a href="https://msdn.microsoft.com/en-us/library/system.collections.arraylist.insert(v=vs.110).aspx"><code>Insert()</code></a> and <a href="https://msdn.microsoft.com/en-us/library/system.collections.arraylist.removeat(v=vs.110).aspx"><code>RemoveAt()</code></a>.This way seems more coherent with the video listed below.</i>
        <br/>
        <br/>
        For time execution between <code>insertsort( int[] numbers )</code> and <code>insertsort1( int[] numbers )</code> refer to the <code>Main()</code> method of this class.
    </td>
  </tr>
    <td align="left">
      <b>The Recipe:</b>
      <br/>
      <br/>
      This algorithm converts the parameter array to an ArrayList. The comparison starts at the second element at index [i] (as the current) with its previous element(s) at index [j-1], where <b>i</b> = 1 and <b>j</b> = <b>i</b>.
      <br/>
      <br/>
      The insertion is made when one of the previous elements is found to be larger than the current. A copy of the current element is inserted at the this previous element's position, enlarging the list by one index (as this previous element is not replaced but its position moves up by one index). To remove the current element's original copy, it is removed at original position + 1 (since the list is now enlarged by 1). Current's new position is then updated.
      <br/>
      <br/>
      The sorting is finished when the iteration reaches the last element in the ArrayList.
      <br/>
      <br/>
      <a href="https://www.youtube.com/watch?v=juf0OL0hYxY">Insertion Sort Video</a>
    </td>
</table>

### [:o:](https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#select) [SelectionSort.cs]
## Complementing Classes  

### [executiontimer.cs]()  

### [IO.cs]()  

### [RandomNum.cs]()  

## Note on adding CSS to HTML on Markdown files on Github:

Inline style attributes are always removed after rendering (e.g. within `<table>` tag). I have not identified the source of this outcome. This outcome can be seen using "inspect" tool on Chrome, inspect this page by doing <kbd>&#8984;</kbd> or <kbd>CTRL</kbd>+<kbd>⌥</kbd>+<kbd>C</kbd>.  

Locate the `<table>` tag and notice that the style attribute does not show on that particular element despite being on this README; some function is overriding this attribute.  

So to maintain equal table sizes throughout this README, keep sentences as long as possible to max out the table width within this README `<article>` tag.    

Hence I could not use the style attribute to add rounded corners to the tables on this README.  
