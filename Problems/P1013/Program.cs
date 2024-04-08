/*
The formula makes no sense. Make a simple comparison between the three integers.
*/

/*
Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:
Maior = (a + b + abs(a - b)) / 2

Input
The input file contains 3 integer values.

Output
Print the greatest of these three values followed by a space and the message “eh o maior”.
*/

string abs = Console.ReadLine();

int firstSpace = abs.IndexOf(" ");
int secondSpace = abs.LastIndexOf(" ");

int a = Int32.Parse(abs.Substring(0, firstSpace-0));
int b = Int32.Parse(abs.Substring(firstSpace+1, secondSpace-firstSpace));
int s = Int32.Parse(abs.Substring(secondSpace+1));

int Maior = a;

if (b > Maior)
{
    Maior = b;
}
if (s > Maior)
{
    Maior = s;
}

Console.WriteLine($"{Maior} eh o maior");