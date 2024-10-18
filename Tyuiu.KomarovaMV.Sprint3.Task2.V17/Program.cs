using Tyuiu.KomarovaMV.Sprint3.Task2.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #2                                                                 *");
        Console.WriteLine("* Вариант #17                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет произведение*");
        Console.WriteLine("* ряда по формуле                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("   10                                                                        *");
        Console.WriteLine("s= ∑ (1/(cos(k)+2)^2                                                         *");
        Console.WriteLine("  k=1                                                                        *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        int i = 1;
        int j = 10;
        Console.WriteLine(ds.GetSumSeries(i, j));
    }
}