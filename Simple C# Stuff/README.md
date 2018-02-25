**To Compile and Run C# on MacOS X:**

(1) Have MONO Installed

- The Mono package includes:

The Mono Runtime
GUI Toolkits: Windows.Forms and Gtk# for OSX.
Note: the MonoMac GUI toolkit for native OSX GUI development is currently a separate download.
SDK: C#, Visual Basic compilers, assemblers and tools
XSP ASP.NET server
Manual pages

http://www.mono-project.com/docs/about-mono/supported-platforms/osx/

(2) Have an IDE with OmniSharp installed

- This is a server that will enable the code editor to have properties of a C# IDE
- omnisharp-atom (via preferences/install or using apm)
- The green fire symbol on the bottom left of the atom window indicates that the OmniSharp server is running


**To compile a .cs file:**

`$ mcs filename.cs`

**To run the c# executable:**

`$ mono filename.exe`

http://www.mono-project.com/docs/getting-started/mono-basics/
