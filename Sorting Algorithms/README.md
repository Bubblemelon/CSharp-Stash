# Sorting Algorithms  

### [BubbleSort.cs]()  

<table style="width:100%">
  <tr>
    <td colspan="2" align="center"><code>BubbleSort</code> Class</td>
  </tr>
  <tr>
    <td nowrap><code>bubblesorting( int[] numbers )</code></th>
    <td align="left">
        This function takes an array of unsorted integers.
        Returns a sorted array in ascending order.
        <br/>
        For a descending order refer to <a href="https://github.com/Bubblemelon/Ruby-Stuff/blob/master/ruby%20practice/bubblesort.rb">bubblesort.rb</a>
    </td>
  </tr>
</table>

### [InsertionSort.cs]()  

### [SelectionSort.cs]()  

## Complementing Classes  

### [executiontimer.cs]()  

### [IO.cs]()  

### [RandomNum.cs]()  

# Note on adding CSS to HTML on Markdown files on Github:

Inline style attributes are always removed after rendering (e.g. within `<table>` tag). I have not identified the source of this outcome. This outcome can be seen using "inspect" tool on Chrome, inspect this page by doing <kbd>&#8984;</kbd> or <kbd>CTRL</kbd>+<kbd>⌥</kbd>+<kbd>C</kbd>. Locate the `<table>` tag and notice that the style attribute does not show on that particular element despite being on this README; some function is overriding this attribute.  

So to maintain equal table sizes throughout this README, keep sentences as long as possible to max out the table width within this README `<article>` tag.    

Hence I could not use the style attribute to add rounded corners to the tables on this README.  
