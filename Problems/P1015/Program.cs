/*
Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and
calculate the distance between them, showing four decimal places after the comma, according to the formula:

Distance = Sqrt((x2 - x1)^2 + (y2 - y1)^2)

Input
The input file contains two lines of data. The first one contains two double values: x1 y1 and the second one also contains two double values with one digit after the decimal point: x2 y2.

Output
Calculate and print the distance value using the provided formula, with 4 digits after the decimal point.
*/

string xy1 = Console.ReadLine();
string xy2 = Console.ReadLine();

int xy1Space = xy1.IndexOf(" ");
int xy2Space = xy2.IndexOf(" ");

double x1 = double.Parse(xy1.Substring(0, xy1Space-0));
double y1 = double.Parse(xy1.Substring(xy1Space+1));
double x2 = double.Parse(xy2.Substring(0, xy2Space-0));
double y2 = double.Parse(xy2.Substring(xy2Space+1));

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(distance.ToString("0.0000"));