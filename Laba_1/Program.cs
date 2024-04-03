double n = Convert.ToDouble(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
double result = (Math.PI / 2);
if (Math.Abs(x) > 1)
{
    for (int i = 0; i <= n; i++)
    {
        result += (((Math.Pow(-1, n + 1)) / (2 * n + 1) * (Math.Pow(x, 2 * n + 1))));
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Значение X выходит за предел");
}