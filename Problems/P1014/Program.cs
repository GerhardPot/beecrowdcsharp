/*
Calculate a car's average consumption being provided the total distance traveled (in Km) and the spent fuel total (in liters).

Input
The input file contains two values: one integer value X representing the total distance (in Km) and
the second one is a floating point number Y representing the spent fuel total, with a digit after the decimal point.

Output
Present a value that represents the average consumption of a car with 3 digits after the decimal point, followed by the message "km/l".
*/

int distance = Int32.Parse(Console.ReadLine());

float spentFuel = float.Parse(Console.ReadLine());

float averageConsumption = (float)distance / spentFuel;

Console.WriteLine($"{averageConsumption.ToString("0.000")} km/l");