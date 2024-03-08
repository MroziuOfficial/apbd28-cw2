// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string x;
x = Console.ReadLine();
string y = "def";
string z = x + y;
Console.WriteLine(x + " " + "abc");
Console.WriteLine(z);
if (x.Equals("abc"))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

static double GetAverage(int[] tab)
{
    double result = 0.0;
    for (int i = 0; i < tab.Length; i++)
    {
        result += tab[i];
    }

    return result / tab.Length;
}

int[] tab = {1, 2, 3, 4};

double avg = GetAverage(tab);
Console.WriteLine(avg);