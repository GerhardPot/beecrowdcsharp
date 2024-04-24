/*
Read 3 floating-point numbers. After, print the roots of bhaskara’s formula.
If it's impossible to calculate the roots because a division by zero or a square
root of a negative number, presents the message “Impossivel calcular”.

Input
Read 3 floating-point numbers (double) A, B and C.

Output
Print the result with 5 digits after the decimal point or the message if it is
impossible to calculate.

Bhaskara's Formula is:
x1 = (-b + sqrt(b^2 - 4ac)) / 2a
x2 = (-b - sqrt(b^2 - 4ac)) / 2a
*/

string abc = Console.ReadLine();
double a, b, c;
int space;

space = abc.IndexOf(" ");
a = double.Parse(abc.Substring(0, space));
abc = abc.Substring(space+1);
space = abc.IndexOf(" ");
b = double.Parse(abc.Substring(0, space));
c = double.Parse(abc.Substring(space));

double discriminant = (b * b) - (4 * a * c);

if (discriminant < 0 || a == 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double r1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double r2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"R1 = {r1.ToString("0.00000")}");
    Console.WriteLine($"R2 = {r2.ToString("0.00000")}");
}