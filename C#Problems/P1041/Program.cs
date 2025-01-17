﻿/*
Write an algorithm that reads two floating values (x and y),
which should represent the coordinates of a point in a plane.
Next, determine which quadrant the point belongs, or if you are at
one of the Cartesian axes or the origin (x = y = 0).

If the point is at the origin, write the message "Origem".

If the point is at X axis write "Eixo X", else if the point is at
Y axis write "Eixo Y".

Input
The input contains the coordinates of a point.

Output
The output should display the quadrant in which the point is.
*/

string coordinates = Console.ReadLine();

int space = coordinates.IndexOf(' ');
float x = float.Parse(coordinates.Substring(0, space));
float y = float.Parse(coordinates.Substring(space + 1));

if (x == 0 && y != 0)
{
    Console.WriteLine("Eixo Y");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("Eixo X");
}

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
};