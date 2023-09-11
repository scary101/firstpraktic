string user_input_numA;
string user_input_numB;
float result = 1;
string action = "0";
do
{
    Console.WriteLine("1.Сложение");
    Console.WriteLine("2.Вычитание");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Деление");
    Console.WriteLine("5.Возвести в степень первое число");
    Console.WriteLine("6.Вычеслить квадратный корень из первого числа");
    Console.WriteLine("7.Вычеслить 1% от первого числа");
    Console.WriteLine("8.Вычеслить факториал первого числа");
    Console.WriteLine("9.Выйти из программы");

    Console.WriteLine("Введите операцию:");
    action = Console.ReadLine();


    while (action != "9")
    {

        Console.WriteLine("Введите первое число:");
        user_input_numA = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        user_input_numB = Console.ReadLine();

        float a2;
        float b2;

        bool a1 = Single.TryParse(user_input_numA, out b2);
        bool b1 = Single.TryParse(user_input_numB, out b2);


        if ((a1 & b1) == true)
        {
            byte p;
        }
        else
        {
            Console.WriteLine("Введите число!!!");
        }

        float a = Convert.ToSingle(user_input_numA);
        float b = Convert.ToSingle(user_input_numB);



        if ((a1 & b1) == true)
        {
            byte p;
        }
        else
        {
            Console.WriteLine("Введите число!!!");
        }


        if (action == "1")
        {
            result = a + b;
        }
        else if (action == "2")
        {
            result = a - b;
        }
        else if (action == "3")
        {
            result = a * b;
        }
        else if (action == "4")
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                result = a / b;
            }

        }
        else if (action == "5")
        {
            Console.WriteLine("Введите степень в которую возвести ваше число:");
            string m = Console.ReadLine();

            float m2;
            bool m3 = Single.TryParse(m, out m2);
            if (m3 == true)
            {
                float m1 = Convert.ToSingle(m);
                result = Convert.ToSingle(Math.Pow(a, m1));
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }



        }
        else if (action == "6")
        {
            if (a < 0)
            {
                Console.WriteLine("Корня из отрицательного числа не бывает!!!");
            }
            else
            {
                result = Convert.ToSingle(Math.Sqrt(a));
            }
        }
        else if (action == "7")
        {
            result = a / 100;
        }
        else if (action == "8")
        {
            if (a < 0 ^ Convert.ToInt32(a) != Convert.ToSingle(a))
            {
                Console.WriteLine("Введите целое, не отрицательное число!");
            }
            else
            {
                for (int i = 1; i <= a; i++)      
                {
                    result = result * i;
                }
            }


        }
        else
        {
            Console.WriteLine("Введите корректное дейсвтие!");
        }

        Console.WriteLine("Результат:" + result);
        result = 0;
        Console.WriteLine("Введите операцию");
        action = Console.ReadLine();


    }


} while (action != "9");