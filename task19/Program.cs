void Palindrom(int Digit)
{
    string StrDigit  = Digit.ToString();
    if (StrDigit.Length == 5 && StrDigit[0]==StrDigit[4] && StrDigit[1]==StrDigit[3])
    {
        Console.WriteLine($"{Digit} является палиндромом");
    }
    else
    {
        Console.WriteLine($"{Digit} не является палиндромом или не является пятизначным числом");
    }  
}

Palindrom(Convert.ToInt32(Console.ReadLine()));
