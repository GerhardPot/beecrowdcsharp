/*
Read an integer value corresponding to a person's age (in days) and print it in years, months and days, followed by its respective message “ano(s)”, “mes(es)”, “dia(s)”.

Note: only to facilitate the calculation, consider the whole year with 365 days and 30 days every month.
In the cases of test there will never be a situation that allows 12 months and some days, like 360, 363 or 364.
This is just an exercise for the purpose of testing simple mathematical reasoning.

Input
The input file contains 1 integer value.

Output
Print the output, like the following example.
*/

int age = Int32.Parse(Console.ReadLine()); // days

int yearDuration = 365; // days
int monthDuration = 30; // days

int years = 0;
int months = 0;
int days = 0;

// calculate years
if (age >= yearDuration)
{
    years = age / yearDuration;
    age -= years * yearDuration;
}

// calculate months
if (age >= monthDuration)
{
    months = age / monthDuration;
    age -= months * monthDuration;
}

days = age;

// display
Console.WriteLine($"{years} ano(s)\n{months} mes(es)\n{days} dia(s)");