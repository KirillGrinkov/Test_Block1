// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using System.Linq;

class Programm
{
    //   Первое меню метод позвоюляющий выбрать готовый массив или выбрать самостоятельный ввод массива
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("********************************MENU********************************");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("*                         Выберите действие                        *");
        Console.WriteLine("*                            Варианты:                             *");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("*                 1 - Ввести массив самостоятельно                 *");
        Console.WriteLine("*                 2 - Выбрать имеющийся массив                     *");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine();
        Console.WriteLine("Введите вариант: ");
        int answer1 = int.Parse(Console.ReadLine() ?? "");

        if (answer1 == 1)
        {
            SelfInput();
        }
        else if (answer1 == 2)
        {
            MenuTwo();
        }
    }

    //   Метод самостоятельного ввода массива
    static void SelfInput()
    {
        Console.WriteLine("Введите элементы массива через запятую, затем нажмите Enter:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }
    // Метод фильтрации выбранного массива
    static string[] FilterArray(string[] inputArray)
    {
        var filteredArray = inputArray.Where(item => item.Trim().Length <= 3).ToArray();
        return filteredArray;
    }
    //  Второе меню - выбор заранее заготовленных массивов
    static void MenuTwo()
    {
        Console.Clear();
        Console.WriteLine("********************************MENU********************************");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("*                     Выберите номер массива                       *");
        Console.WriteLine("*                            Варианты:                             *");
        Console.WriteLine("*      1 - Массив [“Hello”, “2”, “world”, “:-)”]                   *");
        Console.WriteLine("*      2 - Массив [“1234”, “1567”, “-2”, “computer science”]       *");
        Console.WriteLine("*      3 - Массив [“Russia”, “Denmark”, “Kazan”]                   *");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine();
        Console.WriteLine("Введите вариант: ");
        

        int answer2 = int.Parse(Console.ReadLine() ?? "");
        string[] arr1 = { "Hello", "2", "world", ":-)" };
        string[] arr2 = { "1234", "1567", "-2", "computer science" };
        string[] arr3 = { "Russia", "Denmark", "Kazan" };

        string[] resultArray = {};

        switch (answer2)
        {
            case 1:
                resultArray = FilterArray(arr1);
                break;
            case 2:
                resultArray = FilterArray(arr2);
                break;
            case 3:
                resultArray = FilterArray(arr3);
                break;
        }

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }
}
