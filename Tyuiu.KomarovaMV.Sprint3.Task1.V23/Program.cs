using Tyuiu.KomarovaMV.Sprint3.Task1.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #1                                                                 *");
        Console.WriteLine("* Вариант #23                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Написать программу используя цикл while, которая вычисляет произведение ряда*");
        Console.WriteLine("*  по формуле, при X=5                                                       *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("   5                                                                         *");
        Console.WriteLine("p= П (300/(sin(x)+x^k)^k                                                     *");
        Console.WriteLine("  k=1                                                                        *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        int x = 5;
        int i = 1;
        int j = 5;
        Console.WriteLine(ds.GetMultiplySeries(x, i, j));
    }
}