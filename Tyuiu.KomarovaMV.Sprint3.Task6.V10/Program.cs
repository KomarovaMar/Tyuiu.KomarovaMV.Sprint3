using Tyuiu.KomarovaMV.Sprint3.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт#3                                                                   *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                           *");
        Console.WriteLine("* Задание #6                                                                 *");
        Console.WriteLine("* Вариант #10                                                                *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                    *");
        Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих числовому *");
        Console.WriteLine("*отрезку [20, 32] сумму всех делителей больше 12                             *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        int a = 20;
        int b = 32;
        Console.WriteLine(ds.GetSumTheDivisors(a, b));
    }
}