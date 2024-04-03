/*
Read four integer values named A, B, C and D. Calculate and print the difference of product A and B by the product of C and D (A * B - C * D).

Input
The input file contains 4 integer values.

Output
Print DIFERENCA (DIFFERENCE in Portuguese) with all the capital letters, according to the following example, with a blank space before and after the equal signal.
*/

int A = Int32.Parse(Console.ReadLine());

int B = Int32.Parse(Console.ReadLine());

int C = Int32.Parse(Console.ReadLine());

int D = Int32.Parse(Console.ReadLine());

int DIFERENCA = (A * B) - (C * D);

Console.WriteLine($"DIFERENCA = {DIFERENCA}");