﻿class Program
{
    static void Main(string[] args)
    {
        /*Написати програму, яка б виводила на екран консолі кожну з 8-ми змінних. 
          Підібрати тип для змінних, які б в собі розмістили наступні значення:*/

        // 1. Вік людини
        byte ageHuman = 28;
        Console.WriteLine($"1. Возраст человека: {ageHuman} лет");

        // 2. Банківський рахунок з лімітом від -1 000 000 000 000 до 1 000 000 000 000 грн
        double bankSaving = 999_000_434_644.00;
        Console.WriteLine($"2. Банковский счет составляет: {bankSaving} грн.");

        // 3. Літера
        char letter = 'A';
        Console.WriteLine($"3. Буква: \"{letter}\"");

        // 4. SMS повідомлення: `Hello World`
        string massage = "4. Hello World";
        Console.WriteLine(massage);

        // 5. Дати оцінку твердженню: "Сусід сказав, що людина може жити 1000 років". (Правда\Брехня, вмістити в 1 байт)
        bool statement = false;
        if (statement)
        {
            Console.WriteLine($"5. {statement}");
        }
        else
        {
            Console.WriteLine($"5. {statement}");
        }

        // 6. Температуру людини
        float humanTemperature = 36.6f;
        Console.WriteLine($"6. Температура человека: {humanTemperature}");

        // 7. Кількість населення планети
        ulong numberPeopleOnEarth = 7_888_000_000;
        Console.WriteLine($"7. Количество людей на планете составляет: ~{numberPeopleOnEarth}");

        //8. Температуру навколишньго середовища в Укриїні
        float temperatureInUkrain = -10.5f;
        Console.WriteLine($"8. Температура в Украине: {temperatureInUkrain} градуса по цельсию");

        /* Вимога 1.
           Необхідно раціонально оцінити допустиму мінімальну\максимальну величину значення для кожноЇ змінноЇ.
           Вимога 2.
           Використовуйте назви змінних такі, щоб було зрозуміло, що та змінна в собі має містити(наприклад, змінна, яка буде містити вік дерева буду мати ім'я "treeAge" ).
           Вимога 3.
           Завдання виконати для консольного додатку.
           Вимога 4.
           Зберегти виконане рішення в репозиторій, який був створений у попередньому домашньому завданні.
        */
    }
}