/*
In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2,
the number of units of product 2 and the price for one unit of product 2. After this, calculate and show the amount to be paid.

Input
The input file contains two lines of data. In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point.

Output
The output file must be a message like the following example where "Valor a pagar" means Value to Pay.
Remember the space after ":" and after "R$" symbol. The value must be presented with 2 digits after the point.
*/

string productA = Console.ReadLine();

string productB = Console.ReadLine();

float total = 0;

for (int i = 0; i < 2; i++)
{
    if (i == 0)
    {
        int firstSpace = productA.IndexOf(" ");
        int lastSpace = productA.LastIndexOf(" ");

        int codeA = Int32.Parse(productA.Substring(0, firstSpace-0));
        int amountA = Int32.Parse(productA.Substring(firstSpace+1, lastSpace-firstSpace));
        float priceA = float.Parse(productA.Substring(lastSpace+1));

        total += amountA * priceA;
    }
    else if (i == 1)
    {
        int firstSpace = productB.IndexOf(" ");
        int lastSpace = productB.LastIndexOf(" ");

        int codeB = Int32.Parse(productB.Substring(0, firstSpace-0));
        int amountB = Int32.Parse(productB.Substring(firstSpace+1, lastSpace-firstSpace));
        float priceB = float.Parse(productB.Substring(lastSpace+1));

        total += amountB * priceB;
    }
}

Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("0.00")}");