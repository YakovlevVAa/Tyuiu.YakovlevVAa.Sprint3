using Tyuiu.YakovlevVAa.Sprint3.Task3.V3.Lib;
namespace Tyuiu.YakovlevVAa.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Яковлев В. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: cvbmzff orffgtrr dkfvfffdr   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "cvbmzff orffgtrr dkfvfffdr";
            char c = 'f';
            Console.WriteLine("Строка =" + str);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMinCharCount(str, c));
        }
    }
}
