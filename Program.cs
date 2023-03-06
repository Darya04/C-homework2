/*Task 1 Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/

// int CutNumber (int num)    

//  {
//    int first = num / 100;
//    int third = num % 10;
//    int second = num % 100;
//    int result =  second / 10;

//    return result;
//     }

// Console.Write("Input a number for checking: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int newNumber = CutNumber(number);
// Console.Write($"вторая цифра  {newNumber}");


/*Task 2 Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.*/

// Console.Write("Input a number for checking: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num / 1000 == 0 ) // Не знаю, как указать диапазон 
// {
// int last = num / 100;
// int first = num % 100;
// int result = first / 100;
// Console.WriteLine (result);
// }
// else
// {
//     Console.WriteLine ("Нет");
// }

/*Task 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным..*/

// void DayWeek (int num)
// {
// if (num == 6 || num == 7)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine ("нет");
//     }
// }

// Console.Write("Input a day for checking: ");
// int number = Convert.ToInt32(Console.ReadLine());
// DayWeek(number);
