using System;

class DecimalToBinaryConverter
{
    static void Main()
    {
        Console.Write("Введите десятичное число: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        string binaryNumber = DecimalToBinary(decimalNumber);

        Console.WriteLine($"Двоичное число: {binaryNumber}");
    }

    static string DecimalToBinary(long decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binary = "";

        while (decimalNumber > 0)
        {
            long remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;
        }

        return binary;
    }
}
