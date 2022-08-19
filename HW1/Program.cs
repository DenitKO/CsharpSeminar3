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

Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int CountOfDigit(int WhatCount)
{ 
    int i = 0;
    for (; WhatCount>0; i++)
    {
        WhatCount/=10;
    }
    return i;
}
int n = CountOfDigit(number);

int[] ArrayForPalindrom = new int[n];

if (n == 5)
{
    for (int i=0; i<5; i++)
    {
        ArrayForPalindrom[i]=(number/Exponentiation(10, 4-i) % 10);
    }
    if ((ArrayForPalindrom[0] == ArrayForPalindrom[4])&(ArrayForPalindrom[1] == ArrayForPalindrom[3]))
        {    
            Console.WriteLine("Число является полиндромом");
        }
    else Console.WriteLine("Число не является полиндромом");
}
else Console.WriteLine("Число не пятизначное");