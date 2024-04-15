/*
Read a value of floating point with two decimal places. This represents a monetary value.
After this, calculate the smallest possible number of notes and coins on which the value can be decomposed.
The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01.
Print the message “NOTAS:” followed by the list of notes and the message “MOEDAS:” followed by the list of coins.

Input
The input file contains a value of floating point N (0 ≤ N ≤ 1000000.00).

Output
Print the minimum quantity of banknotes and coins necessary to change the initial value, as the given example.
*/

// notes and coins value
float[] notes = {100f, 50f, 20f, 10f, 5f, 2f};
float[] coins = {100f, 50f, 25f, 10f, 5f, 1f};

// default values
float hundredDisplay = 0;
float fiftyDisplay = 0;
float twentyDisplay = 0;
float tenDisplay = 0;
float fiveDisplay = 0;
float twoDisplay = 0;
float oneDisplay = 0;
float halfDisplay = 0;
float quarterDisplay = 0;
float tenthDisplay = 0;
float fifthDisplay = 0;

// calculations
float money = float.Parse(Console.ReadLine());

// notes
if (money >= notes[0])
{
    hundredDisplay = (int)(money / notes[0]);
    money -= hundredDisplay * notes[0];    
}
if (money >= notes[1])
{
    fiftyDisplay = (int)(money / notes[1]);
    money -= fiftyDisplay * notes[1];    
}
if (money >= notes[2])
{
    twentyDisplay = (int)(money / notes[2]);
    money -= twentyDisplay * notes[2];    
}
if (money >= notes[3])
{
    tenDisplay = (int)(money / notes[3]);
    money -= tenDisplay * notes[3];    
}
if (money >= notes[4])
{
    fiveDisplay = (int)(money / notes[4]);
    money -= fiveDisplay * notes[4];    
}
if (money >= notes[5])
{
    twoDisplay = (int)(money / notes[5]);
    money -= twoDisplay * notes[5];    
}

// coins
money *= 100;

if (money >= coins[0])
{
    oneDisplay = (int)(money / coins[0]);
    money -= oneDisplay * coins[0];    
}
if (money >= coins[1])
{
    halfDisplay = (int)(money / coins[1]);
    money -= halfDisplay * coins[1];    
}
if (money >= coins[2])
{
    quarterDisplay = (int)(money / coins[2]);
    money -= quarterDisplay * coins[2];    
}
if (money >= coins[3])
{
    tenthDisplay = (int)(money / coins[3]);
    money -= tenthDisplay * coins[3];    
}
if (money >= coins[4])
{
    fifthDisplay = (int)(money / coins[4]);
    money -= fifthDisplay * coins[4];    
}

Console.WriteLine($"NOTAS:");
Console.WriteLine($"{hundredDisplay} nota(s) de R$ 100.00");
Console.WriteLine($"{fiftyDisplay} nota(s) de R$ 50.00");
Console.WriteLine($"{twentyDisplay} nota(s) de R$ 20.00");
Console.WriteLine($"{tenDisplay} nota(s) de R$ 10.00");
Console.WriteLine($"{fiveDisplay} nota(s) de R$ 5.00");
Console.WriteLine($"{twoDisplay} nota(s) de R$ 2.00");
Console.WriteLine($"MOEDAS:");
Console.WriteLine($"{oneDisplay} moeda(s) de R$ 1.00");
Console.WriteLine($"{halfDisplay} moeda(s) de R$ 0.50");
Console.WriteLine($"{quarterDisplay} moeda(s) de R$ 0.25");
Console.WriteLine($"{tenthDisplay} moeda(s) de R$ 0.10");
Console.WriteLine($"{fifthDisplay} moeda(s) de R$ 0.05");
Console.WriteLine($"{money.ToString("0")} moeda(s) de R$ 0.01");