/*
Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B
and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values).
Otherwise, write the message “Valores nao aceitos” (Values not accepted).

Input
Four integer numbers A, B, C and D.

Output
Show the corresponding message after the validation of the values​​.
*/

string abcd = Console.ReadLine();

int a = 0;
int b = 0;
int c = 0;
int d = 0;

for (int i = 0; i < 4; i++)
{
    int space = abcd.IndexOf(" ");
    if (i == 0)
    {
        a = Int32.Parse(abcd.Substring(0, space));
        abcd = abcd.Substring(space+1);
    }
    else if (i == 1)
    {
        b = Int32.Parse(abcd.Substring(0, space));
        abcd = abcd.Substring(space+1);
    }
    else if (i == 2)
    {
        c = Int32.Parse(abcd.Substring(0, space));
        abcd = abcd.Substring(space+1);
    }
    else if (i == 3)
    {
        d = Int32.Parse(abcd);
    }
}

if ((b > c) && (d > a) && (c + d > a + b) && (c > -1) && (d > -1) && (a % 2 == 0))
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}