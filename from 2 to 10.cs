using System;

class BinaryToDecimalConverter
{
    static void Main()
    {
        Console.Write("Введите двоичное число: ");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = BinaryToDecimal(binaryNumber);

        Console.WriteLine($"Десятичное число: {decimalNumber}");
    }

    static long BinaryToDecimal(string binary)
    {
        long decimalNumber = 0;
        int power = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                decimalNumber += (long)Math.Pow(2, power);
            }
            power++;
        }

        return decimalNumber;
    }
}
