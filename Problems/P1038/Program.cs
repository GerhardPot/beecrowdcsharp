/*
Using the following table, write a program that reads a code and the amount of an item. After, print the value to pay.
This is a very simple program with the only intention of practice of selection commands.

 | Code |  Specification  |  Price  |
 |  1   | Cachorro Quente | R$ 4.00 |
 |  2   | X-Salada        | R$ 4.50 |
 |  3   | X-Bacon         | R$ 5.00 |
 |  4   | Torrada simples | R$ 2.00 |
 |  5   | Refrigerante    | R$ 1.50 |

Input
The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this item according to the above table.

Output
The output must be a message "Total: R$ " followed by the total value to be paid, with 2 digits after the decimal point.
*/

string input = Console.ReadLine();

int space = input.IndexOf(" ");

int x = int.Parse(input.Substring(0, space));
int y = int.Parse(input.Substring(space+1));

int[] codes = {1, 2, 3, 4, 5};
string[] descriptions = {"Cachorro Quente", "X-Salada", "X-Bacon", "Torrada simples", "Refrigerante"};
float[] price = {4.00f, 4.50f, 5.00f, 2.00f, 1.50f};

int position = Array.IndexOf(codes, x);

float total = price[position] * y;

Console.WriteLine($"Total: R$ {total.ToString("0.00")}");