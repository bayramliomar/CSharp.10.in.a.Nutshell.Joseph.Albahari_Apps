using System.Runtime.CompilerServices;
using Test;

#region others
//var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
//var a2 = a1 with { E = 10, C = 1 };
//Console.WriteLine(a2);
//Console.WriteLine("Hello, World!");

//var point = (3, 4);
//double x = 0;
//(x, double y) = point;

//var greeter = () => Console.WriteLine("Hello, Lambda Expression");

//var addition = int (int a, int b) => a + b;
//greeter();
//int result = addition(10, 20);
Console.WriteLine();

//Print(Math.PI * 2);

//void Print(double number, [CallerArgumentExpression("number")] string expr = null)
//=> Console.WriteLine(expr);


//var foo = new Foo()
//{
//    id = 1
//};


//Point p1 = new Point(2, 3);
//Point p2 = p1 with { Y = 4 }; // p2 is a copy of p1, but with Y set to 4
//Console.WriteLine(p2);
//// Point { X = 2, Y = 4 }
//record Point
//{
//    public Point(double x, double y) => (X, Y) = (x, y);
//    public double X { get; init; }
//    public double Y { get; init; }
//}



//Window firstWindow = new Window { Size = 10, Color = "Red" };


//Window second = firstWindow with { };
////var second = new Window { Size = 10, Color = "Red" };
////var second = firstWindow with { Color = "White" };
//if (firstWindow.Equals(second))
//{
//    Console.WriteLine("Beraber");
//}

//if (firstWindow==second)
//{
//    Console.WriteLine("Beraber2");
//}
//Console.WriteLine($" car1 == car3 {firstWindow == second}");
//Console.WriteLine(firstWindow);


//var first = new Foo { Size = 10, Color = "Red" };


//var secondC = new Foo { Size = 10, Color = "Red" };

//if (first.Equals(secondC))
//{
//    Console.WriteLine("Beraber");
//}

//if (first == secondC)
//{
//    Console.WriteLine("Beraber2");
//}


//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
//char lastElement = vowels[^1]; // 'u'
//char secondToLast = vowels[^2]; // 'o'

//Console.WriteLine(lastElement);
//Console.WriteLine(secondToLast);

//char[] firstTwo = vowels[..2];// 'a', 'e'
//char[] lastThree = vowels[2..];// 'i', 'o', 'u'
//char[] middleOne = vowels[2..3];// 'i'
//char[] lastTwo = vowels[^2..]; // 'o', 'u'

//Console.WriteLine(firstTwo);
//Console.WriteLine(lastThree);
//Console.WriteLine(middleOne);
//Console.WriteLine(lastTwo);

#endregion

#region Numeric suffixes
//long i = 5;
//double x = 4.0;
////float f = 4.5; // Will not compile without the F suffix.
//float f = 4.8F;
////decimal d = 10.7; // Will not compile without the M suffix.
//decimal d = 20.7M;
#endregion

#region Numeric Conversions

#region Converting between integral types
//int x = 12345;// int is a 32-bit integer
//long y = x;// Implicit conversion to 64-bit integral type
//short z = (short)x; // Explicit conversion to 16-bit integral type
#endregion
#region Converting between floating-point and integral types
//int i = 1;//implicit
//float f = i;//implicit
////reverse
//int i2 = (int)f;//explicit

//float f3 = 10.51f;
//int i3 = (int)f3;//does not round 
//int i3c=Convert.ToInt32(f3);//round when .5>
//Console.WriteLine(f3);
//Console.WriteLine(i3);//does not round
//Console.WriteLine(i3c);//round when .5>

//Console.WriteLine("**************************");

//int i4 = 100000001;
//float f4 = i4; // Magnitude preserved, precision lost
//int i5 = (int)f4; //100000000
//Console.WriteLine(i4);
//Console.WriteLine(f4);
//Console.WriteLine(i5);
#endregion

#endregion

#region Arithmetic Operators
//short a = 3;
//short b = 5;
//short c = (short)(a + b);
//Console.WriteLine(c);

//int x = 0, y = 0;
//Console.WriteLine(x++); // Outputs 0; x is now 1
//Console.WriteLine(++y); // Outputs 1; y is now 1

//int a = 2 / 3;
//int b = 0;// 0
//int c = 5 / b;// throws DivideByZeroException

//int a = int.MinValue;
//a--;
//Console.WriteLine(a);
//Console.WriteLine(a == int.MaxValue); // True

//int a = 1000000;
//int b = 1000000;
//int c = checked(a * b);
//checked { int z = a * b; }
//Console.WriteLine(c);

//int x = int.MaxValue;
//int y = unchecked(x + 1);
//unchecked { int z = x + 1; }

//int x = int.MaxValue + 1;// Compile-time error
//int y = unchecked(int.MaxValue + 1); // No errors

#endregion

#region Special Float and Double Values
//Console.WriteLine(double.NaN); // Nana
//Console.WriteLine(double.NegativeInfinity); // -Infinity
//Console.WriteLine(double.PositiveInfinity); // +Infinity
//Console.WriteLine(-0.0); //-0

//Console.WriteLine(float.NaN); // Nana
//Console.WriteLine(float.NegativeInfinity); // -Infinity
//Console.WriteLine(float.PositiveInfinity); // +Infinity
//Console.WriteLine(-0.0); //-0

//Console.WriteLine(1.0 / 0.0);  // Infinity
//Console.WriteLine(-1.0 / 0.0); // -Infinity
//Console.WriteLine(1.0 /-0.0); // -Infinity
//Console.WriteLine(-1.0 / -0.0);// Infinity

//Console.WriteLine(0.0 / 0.0);// NaN
//Console.WriteLine((1.0/0.0)-(1.0/0.0)); // NaN

//Console.WriteLine(0.0 / 0.0 == double.NaN); // False
//Console.WriteLine(double.IsNaN(0.0 / 0.0)); // True
//Console.WriteLine(float.IsNaN(0.0f / 0.0f)); // True
//Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN)); // True
#endregion

#region Real Number Rounding Errors
//float x = 0.1f; // Not quite 0.1
//Console.WriteLine(x); // 0.1
//Console.WriteLine(x + x + x + x + x + x + x + x + x + x); // 1.0000001
//Console.WriteLine();

//double y = 0.1; // Not quite 0.1
//Console.WriteLine(y); // 0.1
//Console.WriteLine(y + y + y + y + y + y + y + y + y + y); // 0.9999999999999999
//Console.WriteLine();

//decimal z = 0.1M;
//Console.WriteLine(z); // 0.1
//Console.WriteLine(z + z + z + z + z + z + z + z + z + z); // 1.0
//Console.WriteLine();

//decimal m = 1M / 6M; // 0.1666666666666666666666666667M
//double d = 1.0 / 6.0;// 0.16666666666666666
//Console.WriteLine(m);
//Console.WriteLine(d);
//Console.WriteLine();
#endregion

#region Boolean Type and Operators
#region Equality and Comparison Operators
//int x = 1;
//int y = 2;
//int z = 1;
//Console.WriteLine(x == y);// False
//Console.WriteLine(x == z);// True
//Console.WriteLine();

////reference types

//Dude d1 = new Dude("John");
//Dude d2 = new Dude("John");
//Console.WriteLine(d1 == d2); // False
//Dude d3 = d1;
//Console.WriteLine(d1 == d3);//True
//class Dude
//{
//	public Dude(string name)
//	{

//	}
//}
//bool a = false;
//int c = Convert.ToInt32(a);
//Console.WriteLine(c);
#endregion
#endregion

#region Strings and Characters

//char copyrightSymbol = '\u00A9';
//char omegaSymbol = '\u03A9';
//char newLine = '\u000A';
//Console.WriteLine(copyrightSymbol);
//Console.WriteLine(omegaSymbol);
//Console.WriteLine(newLine);

//char aa = 'A';
//ushort x = aa;

//string a = "test";
//string b = "test";
//Console.Write(a == b); //true
//Console.WriteLine();

//string escaped = "First Line\r\nSecond Line";
//string verbatim = @"First Line
//Second Line";
//// True if your text editor uses CR-LF line separators:
//Console.WriteLine(escaped == verbatim);
//Console.WriteLine();

//string xml = @"<customer id=""123""></customer>";
//Console.WriteLine(xml);
//Console.WriteLine();

//string s = "a" + 5; // a5

//int x = 4;
//Console.Write($"A square has {x} sides"); // Prints: A square has 4 sides
//Console.WriteLine();

//string s = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit hexadecimal // Evaluates to "255 in hex is FF"
//Console.WriteLine(s);
//Console.WriteLine();

//int x = 2;
//// Note that $ must appear before @ prior to C# 8:
//string s = $@"this interpolation spans {x} lines";
//Console.WriteLine();


//const string greeting = "Hello";
//const string message = $"{greeting}, world";
#endregion

#region Array
//char[] vowels = new char[5]; // Declare an array of 5 characters
//vowels[0] = 'a';
//vowels[1] = 'e';
//vowels[2] = 'i';
//vowels[3] = 'o';
//vowels[4] = 'u';
//Console.WriteLine(vowels[1]); // e
//for (int i = 0; i < vowels.Length; i++)
//    Console.Write(vowels[i]); // aeiou

//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
//char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };

//Point[] a = new Point[1000];
//int x = a[500].X; // 0
//Console.WriteLine(x);
//public struct Point { public int X, Y; }

//Point[] a = new Point[1000];
//int x = a[500].X; // Runtime error, NullReferenceException
//Console.WriteLine(x);

//Point[] a = new Point[1000];
//for (int i = 0; i < a.Length; i++) // Iterate i from 0 to 999
//    a[i] = new Point(); // Set array element i with new point
//public class Point { public int X, Y; }

//int[] a = null;

#endregion

#region Indices and Ranges
#region Indices
//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
//char lastElement = vowels[^1]; // 'u'
//char secondToLast = vowels[^2]; // 'o'
//Console.WriteLine(lastElement);
//Console.WriteLine(secondToLast);
//Console.WriteLine();

//Index first = 0;
//Index last = ^1;
//char firstElement_ = vowels[first]; // 'a'
//char lastElement_ = vowels[last]; // 'u'
//Console.WriteLine(firstElement_);
//Console.WriteLine(lastElement_);
//Console.WriteLine();
#endregion
#region Ranges
//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
//char[] firstTwo = vowels[..2]; // 'a', 'e'
//char[] firstTwo2 = vowels[..3]; // 'a', 'e'
//char[] firstTwo3 = vowels[..1]; // 'a', 'e'
//char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
//char[] middleOne = vowels[2..3]; // 'i'
//char[] four = vowels[3..4]; // 'o'
//char[] five = vowels[1..4]; // 'eio'
//Console.WriteLine(firstTwo);
//Console.WriteLine(firstTwo2);
//Console.WriteLine(firstTwo3);
//Console.WriteLine(lastThree);
//Console.WriteLine(middleOne);
//Console.WriteLine(four);
//Console.WriteLine(five);
//Console.WriteLine();

//Range firstTwoRange = 0..2;
//char[] firstTwo_ = vowels[firstTwoRange]; //
//Console.WriteLine(firstTwo_);
//Console.WriteLine();

//char[] reverse = vowels[^2..]; // 'o,u'
//Console.WriteLine(reverse);
//Console.WriteLine();
#endregion
#endregion

#region Multidimensional Arrays
#region Rectangular arrays
//int[,] matrix = new int[3, 6];
//int dim1 = matrix.GetLength(0);//3
//int dim2 = matrix.GetLength(1);//6
//matrix = new int[3, 3];
//for (int i = 0; i < matrix.GetLength(0); i++)
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = i * 3 + j;
//        Console.WriteLine($"matrix[{i},{j}]={i * 3 + j}");
//    }

//int[,] matrix2 = new int[,]
//{
// {0,1,2},
// {3,4,5},
// {6,7,8}
//};
#endregion
#region Jagged arrays
int[][] matrix = new int[3][];
//int[][] matrix2 = new int[][3];
#endregion
#endregion