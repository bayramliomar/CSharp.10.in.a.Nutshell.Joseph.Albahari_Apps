using example;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Test;
using Test.Concrete;




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

#region CSharp.10.in.a.Nutshell.Joseph.Albahari
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
//int[][] matrix = new int[3][];
//int[][] matrix2 = new int[][3];

//int[] arr = new int[3];
//arr[3] = 1; // IndexOutOfRangeException thrown
#endregion
#endregion

#region Variables and Parameters

#region Heap
//StringBuilder ref1 = new StringBuilder("object1");
//Console.WriteLine(ref1);
//// The StringBuilder referenced by ref1 is now eligible for GC.
//StringBuilder ref2 = new StringBuilder("object2");
//StringBuilder ref3 = ref2;
//// The StringBuilder referenced by ref2 is NOT yet eligible for GC.
//Console.WriteLine(ref3); // object2
#endregion

#endregion

#region Definite Assignment
//int x;
//Console.WriteLine(x); // Compile-time error

//Test a=new Test();
//Console.WriteLine(a.y);
//class Test{
//   public int y;
//}

//int[] ints = new int[2];
//Console.WriteLine(ints[0]); // 0
#endregion

#region Parameters
//Passing arguments by value
//int x = 8;
//Foo(x); // Make a copy of x
//Console.WriteLine(x); // x will still be 8
//static void Foo(int p)
//{
//    p = p + 1; // Increment p by 1
//    Console.WriteLine(p); // Write p to screen
//}
/*------------------------------------------*/
//StringBuilder sb = new StringBuilder();
//Foo(sb);
//Console.WriteLine(sb.ToString()); // test
//static void Foo( StringBuilder  fooSB)
//{
//    fooSB.Append("test");
//    fooSB = null;
//    //Console.WriteLine(fooSB.ToString());
//}
#region Ref
/*----------------------------------------------*/
//int x = 8;
//Foo2(ref x); // Ask Foo to deal directly with x
//Console.WriteLine(x); // x is now 9
//static void Foo2(ref int p)
//{
//    p = p + 1; // Increment p by 1
//    Console.WriteLine(p); // Write p to screen
//}
/*----------------------------------------------*/
//StringBuilder r_sb = new StringBuilder();
//r_Foo(ref r_sb);
////Console.WriteLine(r_sb.ToString()); // error
//static void r_Foo(ref StringBuilder r_fooSB)
//{
//    r_fooSB.Append("test");
//    r_fooSB = null;
//    //Console.WriteLine(fooSB.ToString());
//}
/*----------------------------------------------*/
//string x = "Penn";
//string y = "Teller";
//Swap(ref x, ref y);
//Console.WriteLine(x); // Teller
//Console.WriteLine(y); // Penn
//static void Swap(ref string a, ref string b)
//{
//    string temp = a;
//    a = b;
//    b = temp;
//}
/*----------------------------------------------*/
#endregion
#region Out
//string a, b;
//string _;
////Split("Stevie Ray Vaughn", out a, out b);
//Split("Stevie Ray Vaughan", out string a, out string b);
//Console.WriteLine(a); // Stevie Ray
//Console.WriteLine(b); // Vaughn
//Split("Stevie1 Ray1 Vaughan1", out string c, out _); // Discard 2nd param
//Console.WriteLine(c);
//Console.WriteLine(_);

//void Split(string name, out string firstNames, out string lastName)
//{
//    int i = name.LastIndexOf(' ');
//    firstNames = name.Substring(0, i);
//    lastName = name.Substring(i + 1);
//}

//Test2.Main();
//class Test2
//{
//    public static int x;
//    public static void Main() { Foo3(out x); }
//    public static void Foo3(out int y)
//    {
//        Console.WriteLine(x); // x is 0
//        y = 1; // Mutate y
//        Console.WriteLine(x); // x is 1
//    }
//}
#endregion
#region in


//Method(5); // OK, temporary variable created.
////Method(5L); // CS1503: no implicit conversion from long to int
//short s = 0;
//Method(s); // OK, temporary int created with the value 0
////Method(in s); // CS1503: cannot convert from in short to in int
//int i = 42;
//Method(i); // passed by readonly reference
//Method(in i); // passed by readonly reference, explicitly using `in`
//static void Method(in int argument)
//{
//    Console.WriteLine(argument);
//    // implementation removed
//}
#endregion
#region params
//int total = Sum(1, 2, 3, 4);
//Console.WriteLine(total); // 10
//// The call to Sum above is equivalent to:
//int total2 = Sum(new int[] { 1, 2, 3, 4 });
//Console.WriteLine(total2); // 10
//int Sum(params int[] ints)
//{
//    int sum = 0;
//    for (int i = 0; i < ints.Length; i++)
//        sum += ints[i]; // Increase sum by ints[i]
//    return sum;
//}

#endregion
#region optional
//Foo(78);
//void Foo(int x = 23) { Console.WriteLine(x); }
#endregion
#region Named arguments
//Foo(x: 1, y: 2); // 1, 2
//Foo(y:9, x: 2);

//Foo(x: 1, 2); // OK. Arguments in the declared positions
//Foo(y: 2, 1); // Compile-time error. y isn't in the first position

//Bar(d: 9);

//void Bar(int a = 0, int b = 0, int c = 0, int d = 0) {  }
//void Foo(int x, int y) { Console.WriteLine(x + ", " + y); }
#endregion
#region Ref Locals
//int[] numbers = { 0, 1, 2, 3, 4 };
//ref int numRef = ref numbers[2];
//Console.WriteLine(numRef);
//numRef = 190;
//Console.WriteLine(numRef);
//Console.WriteLine(numbers[2]);
#endregion
#region Ref Returns
//ref string xRef = ref Program2.RefGetX(); // Assign result to a ref local
//ref string propXRef = ref Program2.Prop; // Assign result to a ref local
////string xRef2 = Program2.RefGetX();
////string x = Program2.GetX(); // Assign result to a ref local
//xRef = "New Value";
////xRef2 = "New Value2";
////x = "New Value2";
//string localX = Program2.RefGetX(); // Legal: localX is an ordinary non-ref variable
//Program2.Prop = "New Y Value";
//Console.WriteLine(Program2.x); // New Value
//Console.WriteLine(Program2.y); // New Value

//public class Program2
//{
//    public static string x = "Old Value";
//    public static string y = "Y Value";
//    public static ref string Prop => ref y;
//    public static ref string RefGetX() => ref x; // This method returns a ref
//    public static string GetX() => x; // This method returns a ref
//}
#endregion
#region Target-Typed new Expressions
//Foo Foo = new Foo("ddsds");

//class Foo
//{
//    System.Text.StringBuilder sb;

//    public Foo(string initialValue)
//    {
//        sb = new(initialValue);
//    }
//}
#endregion


#endregion

#endregion


#region Others
#region Question IChunkArray
//ChunkArray<int> chunkArray = new ChunkArray<int>();
//int[] x = new int[] { 1, 2 };
//int[] y = new int[] { 3, 4, 5 };
//chunkArray.Add(x);
//chunkArray.Add(y);
//Console.WriteLine(chunkArray.Length);

//Console.WriteLine(chunkArray[0]);
//chunkArray[0] = 7;
//Console.WriteLine(chunkArray[0]);
//Console.ReadLine();
#endregion

#region SizeOfStruct
//X x = new X();
//int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(X));
//Console.WriteLine(size);
//struct X
//{
//    int c;
//    int c1;
//    int c2;
//    long a;
//}
#endregion

#region test
//int a;
//long b = long.MaxValue-1;
//a = (int)b;
//Console.WriteLine(a);
#endregion

#region Covariance-Contravariance
#region LinkedList Reverse
//LinkedList list = new LinkedList();
//list.AddNode(new LinkedList.Node(85));
//list.AddNode(new LinkedList.Node(15));
//list.AddNode(new LinkedList.Node(4));
//list.AddNode(new LinkedList.Node(20));

//// List before reversal
//Console.WriteLine("Given linked list ");
//list.PrintList();

//// Reverse the list
//list.ReverseList();

// List after reversal
//Console.WriteLine("Reversed linked list ");
//list.PrintList();
#endregion
#region example namespace
namespace example
{
    // C# program for reversing the linked list

    class LinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // function to add a new node at
        // the end of the list
        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        // function to reverse the list
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        // function to print the list data
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    // This code is contributed by Mayank Sharma

}
#endregion
#endregion

#endregion

