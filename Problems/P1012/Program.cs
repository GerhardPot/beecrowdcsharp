/*
Make a program that reads three floating point values: A, B and C. Then, calculate and show:
a) the area of the rectangled triangle that has base A and height C.
b) the area of the radius's circle C. (pi = 3.14159)
c) the area of the trapezium which has A and B by base, and C by height.
d) the area of ​​the square that has side B.
e) the area of the rectangle that has sides A and B.

Input
The input file contains three double values with one digit after the decimal point.

Output
The output file must contain 5 lines of data. Each line corresponds to one of the areas described above, always with a corresponding message (in Portuguese)
and one space between the two points and the value. The value calculated must be presented with 3 digits after the decimal point.
*/

string abc = Console.ReadLine();

int firstSpace = abc.IndexOf(" ");
int secondSpace = abc.LastIndexOf(" ");

double a = Double.Parse(abc.Substring(0, firstSpace-0));
double b = Double.Parse(abc.Substring(firstSpace+1, secondSpace-firstSpace));
double c = Double.Parse(abc.Substring(secondSpace+1));

double triangle, circle, trapezium, square, rectangle = 0;

// a
triangle = (a / 2d) * c;
Console.WriteLine($"TRIANGULO: {triangle.ToString("0.000")}");

// b
circle = 3.14159d * Math.Pow(c, 2);
Console.WriteLine($"CIRCULO: {circle.ToString("0.000")}");

// c
trapezium = ((a + b) / 2d) * c;
Console.WriteLine($"TRAPEZIO: {trapezium.ToString("0.000")}");

// d
square = Math.Pow(b, 2);
Console.WriteLine($"QUADRADO: {square.ToString("0.000")}");

// e
rectangle = a * b;
Console.WriteLine($"RETANGULO: {rectangle.ToString("0.000")}");