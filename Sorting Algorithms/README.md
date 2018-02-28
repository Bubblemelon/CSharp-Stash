# Sorting Algorithms

#### This has been moved this to the [Wiki section](https://github.com/Bubblemelon/algorithms/wiki/Sorting-Algorithms) of this repository.  
<br/>
The following are some reasons why and what I have discovered before making this decision.  
<br/>

## Notes on using CSS and HTML in Markdown files on Github:  

**Style Attribute:**

Inline style attributes are always removed after rendering (e.g. within `<table>` tag). I have not identified the source of this outcome. This outcome can be seen using "inspect" tool on Chrome, inspect this page by doing <kbd>&#8984;</kbd> or <kbd>CTRL</kbd>+<kbd>⌥</kbd>+<kbd>C</kbd>.  

<br/>
<table style="width:100%">
  <tr>
    <td colspan="2" align="center">
      i
    </td>
  </tr>
  <tr>
    <td rowspan="2" nowrap>
      i
    </td>
    <td align="left">
      i
    </td>
  </tr>
  <tr>
    <td>
      i
    </td>
  </tr>
</table>
<br/>

> **Table:**
>
> Locate the `<table>` tag and notice that the style attribute does not show on this  particular element `<table style="width:100%">`; some Github function is overriding this attribute.  
>
> So to maintain equal table sizes throughout a README, I kept sentences as long as possible to max out the table width within a README `<article>` tag.    
>
> Hence I could not use the style attribute to add rounded corners to the tables on any README.  

<br/>

**Table of Contents:**

Anchor links that jump to a section of a page (table of contents) only work with headers! Not any link can have this functionality, e.g.  

doing \[\`code\`\]\(https://github.com/Bubblemelon/algorithms#code\) does not work.

Additionally this only works on the wiki section of a repository or at the root directory (the above mentioned link is an example of the root), e.g. using this url https://github.com/Bubblemelon/algorithms/tree/master/Sorting%20Algorithms#code which is not the same level as the root directory does not work.  

For this link jump to work, the # portion of the url must in be **lowercases** and for consistency name the tag like so: e.g. \#\#\#Hello There , url#hello\ or url#hello-there .     

Also note that, by doing :o: \#\#\#Hello There (having anything in front of the header) will not work either. In more detail, the following does not work:  
<br/>
>:o: \#\#\#[Hello]\(https://url#hello)
>
>\#\#\#:o: [Hello]\(https://url#hello)
>
>\#\#\#:o: [Hello]\(https://url#:\o:-hello)
