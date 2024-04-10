/*
Read an integer value, which is the duration in seconds of a certain event in a factory, and inform it expressed in hours:minutes:seconds.

Input
The input file contains an integer N.

Output
Print the read time in the input file (seconds) converted in hours:minutes:seconds like the following example.
*/

// given seconds
int N = Int32.Parse(Console.ReadLine());

// minutes - 60
int minutes = N / 60;
N -= (minutes * 60);

// hours - 24
int hours = 0;
if (minutes >= 60)
{
    hours = minutes / 60;
    minutes -= hours * 60;
}

Console.WriteLine($"{hours}:{minutes}:{N}");