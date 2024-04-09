/*
In this problem you have to read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed.
The possible banknotes are 100, 50, 20, 10, 5, 2 and 1. Print the read value and the list of banknotes.

Input
The input file contains an integer value N (0 < N < 1 000 000).

Output
Print the read number and the minimum quantity of each necessary banknotes in Portuguese language, as the given example.
Do not forget to print the end of line after each line, otherwise you will receive “Presentation Error”.
*/

int N = Int32.Parse(Console.ReadLine());
Console.WriteLine(N);

//100
int hundredNotes = N / 100;
N -= hundredNotes * 100;
Console.WriteLine($"{hundredNotes} nota(s) de R$ 100,00");

//50
int fiftyNotes = N / 50;
N -= fiftyNotes * 50;
Console.WriteLine($"{fiftyNotes} nota(s) de R$ 50,00");

//20
int twentyNotes = N / 20;
N -= twentyNotes * 20;
Console.WriteLine($"{twentyNotes} nota(s) de R$ 20,00");

//10
int tenNotes = N / 10;
N -= tenNotes * 10;
Console.WriteLine($"{tenNotes} nota(s) de R$ 10,00");

//5
int fiveNotes = N / 5;
N -= fiveNotes * 5;
Console.WriteLine($"{fiveNotes} nota(s) de R$ 5,00");

//2
int twoNotes = N / 2;
N -= twoNotes * 2;
Console.WriteLine($"{twoNotes} nota(s) de R$ 2,00");

//1
int oneNotes = N / 1;
N -= oneNotes * 1;
Console.WriteLine($"{oneNotes} nota(s) de R$ 1,00");