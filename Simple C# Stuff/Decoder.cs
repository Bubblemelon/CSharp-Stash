using System;
using System.Text;
using System.IO;

/*
* Decodes UTF-7 and explains the Byte Type
*/

public class Decoder {

    public static void Main() {

        //stdin instantiation = Acquires the standard input stream.
        Stream inputStream = Console.OpenStandardInput();

        // Unsigned 8 bit integer
        // Range 0 to 255 decimal
        byte[] bytes = new byte[100];

/*

byte byteValue1 = 201;
Console.WriteLine(byteValue1);

byte byteValue2 = 0x00C9;
Console.WriteLine(byteValue2);

byte byteValue3 = 0b1100_1001;
Console.WriteLine(byteValue3);

// The example displays the following output:
//          201
//          201
//          201

byte byteValue4 = 0b1100_1001;
Console.WriteLine(byteValue3);

byte byteValue5 = 0b_1100_1001;
Console.WriteLine(byteValue3);

// C# 7.2 onwards
// The example displays the following output:
//          201
//          201

byte x = 10, y = 20;

// Error: conversion from int to byte:
byte z = x + y;

// OK: explicit conversion:
byte z = (byte)(x + y);

// OK: destination variable has the same storage size or a larger storage size
int x = 10, y = 20;
int m = x + y;
long n = x + y;

// Error: no implicit conversion from double:
byte x = 3.0;
// OK: explicit conversion:
byte y = (byte)3.0;

*/

        Console.WriteLine("To decode, type or paste the UTF7 encoded string and press enter:");
        Console.WriteLine("(Example: \"M+APw-nchen ist wundervoll\")");

        //Stream.Read(Buffer, Offset, Count)
        int outputLength = inputStream.Read(bytes, 0, 100);
        // saves the user input into the bytes ( an array )

        // (Buffer) It is an array of bytes. When this method returns,
        // the buffer contains the specified byte array with the values between
        // offset and (offset + count - 1) replaced by the bytes read from the
        // current source

        // (Offset) The zero-based byte offset in buffer at which to begin
        // storing the data read from the current stream.

        // (Count) The maximum number of bytes to be read from the current stream.

        // (Return)
        // Type: System.Int32
        // The total number of bytes read into the buffer.
        // This can be less than the number of bytes requested
        // if that many bytes are not currently available,
        // or zero (0) if the end of the stream has been reached.

        //Encoding.GetChars(Bytes, Index, Count)
        // array of chars
        char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);

        // (Bytes)
        // Type: System.Byte[]
        // The byte array containing the sequence of bytes to decode.

        // (Index)
        // Type: System.Int32
        // The index of the first byte to decode.

        // (Count)
        // Type: System.Int32
        // The number of bytes to decode.

        // (Return)
        // Type: System.Char[]
        // A character array containing the results of
        // decoding the specified sequence of bytes.


        // Encoding.UTF7
        // Gets an encoding for the UTF-7 format.

        // Get different encodings. example:
        // Encoding  u7    = Encoding.UTF7;


        Console.WriteLine("Decoded string:");

        Console.WriteLine(new string(chars));

        // String Constructor (Char[])
        // Initializes a new instance of the String class to the value
        // indicated by an array of Unicode characters.

        // Error: String s = new String("Hello World");
        // Reason: overloaded method match for `string.String(char*)'
        // has some invalid arguments
        // Using the constructor to create a new string based on another
        // existing string is un-necessary
        // There is no constructor overload that allows this

    }
}
