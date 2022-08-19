int Exponentiation(int digit, int degree)
{
    int index = 1;
    int ExpDigit=digit;
    if (degree > 0)
    {
        while (index < degree)
        {
            ExpDigit=ExpDigit*digit;
            index++;
        }
    return ExpDigit;
    }
    if (degree < 0)
    {
            while (index < degree)
        {
            ExpDigit=ExpDigit*digit;
            index--;
        }
    return 1/ExpDigit;
    }
    else 
    return 1;
}
Console.WriteLine("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; N > i-1; i++)
{
Console.Write(Exponentiation(i,3));
if (N > i)
Console.Write(", ");
}