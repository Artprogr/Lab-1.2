class Binary1
{
    static int Sum(int num1, int num2)
    {
        int i = 0;
        int a = 0;
        string str = "";

        while (num1 != 0 || num2 != 0)
        {
            str += (num1 % 10 + num2 % 10 + a) % 2;
            a = (num1 % 10 + num2 % 10 + a) / 2;

            num1 = num1 / 10;
            num2 = num2 / 10;
        }

        if (a != 0)
        {
            str += a;
        }

        int result = 0;
        for (i = str.Length - 1; i >= 0; i--)
        {
            result = result * 10 + (int)(str[i] - '0');
        }
        Console.Write(result);
        return 0;
    }

    static void Prod(int num1, int num2)
    {
        int prod = 0;

        while (num2 > 0)
        {
            if (num2 % 10 == 1)
            {
                prod = Sum(prod, num1); 
            }
            num1 *= 10;
            num2 /= 10;
        }
        Console.Write(prod);
    }
    public static void Main()
    {
        try
        {
            int num1 = 0;
            int num2 = 0;
            int num11 = 0;
            int num22 = 0;
            Console.Write("Введите целую часть первого числа: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите дробную часть первого числа: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите целую часть второго числа: ");
            num11 = int.Parse(Console.ReadLine());
            Console.Write("Введите дробную часть второго числа: ");
            num22 = int.Parse(Console.ReadLine());
            Console.Write("Сумма равна: ");
            Sum(num1, num2);
            Console.Write(".");
            Sum(num11, num22);
            Console.WriteLine(" ");
            Console.Write("Произведение равно: ");
            Prod(num1, num2);
            Console.Write(".");
            Prod(num11, num22);
        }
        catch
        {
            Console.WriteLine("Неверный формат");
        }
    }
}