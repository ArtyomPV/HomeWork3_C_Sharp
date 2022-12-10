//=============== Задача 19. ===========================
/*
 Напишите программу, которая принимает на вход 
 пятизначное число и проверяет, является ли оно полиндромом.
 14212 -> нет
 12821 -> да
 23432 -> да
*/

/*
1.  Запросить у пользователя ввести пятизначное число
2.  Проверить является число пятизначным:
    *введенное число не является пятизначным, то завершаем выполнение прогграммы
    *введенное число пятизначное, то продолжаем выполнение задачи.
3.  Сравнить первое и последнее числа: 
    *если они не равны друг другу, то выводит сообщение, 
        что введенное число не является палиндрмном, и выходим из программы
    *если они равны друг другу, то продолжаеи выполнение программы
4.  Сравниваем второе и предпоследние числа:     
    *если они не равны друг другу, то выводит сообщение, 
        что введенное число не является палиндромом, и выходим из программы
    *если они равны друг другу, то продолжаеи выполнение программы.
5.  Выводим сообщение о том, что введенное число является палиндромом

*/

// int GetNumber()
// {
//     Console.Write("Enter a five-digit number: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// void CheckNumberIsPalindrom(int num)
// {
//     if(num<9999 || num>99999) Console.WriteLine("Entered wrong number!");
//     else
//     {
//         int n1 = num/10000;
//         int n5 = num%10;
//         int tempNumber = (num%10000)/10;
//         int n2 = tempNumber/100;
//         int n4 = tempNumber%10;
        
//         if(n1 != n5) Console.WriteLine($"Entred number {num} is not а palindrome.");
//         else
//         {
//             if(n2 != n4) Console.WriteLine($"Entred number {num} is not а palindrome.");
//             else Console.WriteLine($"Entered number {num} is а palindrome.");
//         }
//     }
// }

// int fiveDigitNumber = GetNumber();
// CheckNumberIsPalindrom(fiveDigitNumber);


//=============== Задача 21. ===========================
/*
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве
A(3,6,8);   B(2, 1, -7) -> 15.84
A(7, -5, 0);B(1, -1, 9) ->11.53
*/

// double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
//     return distance;
// }

// Console.Write("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dis = CalcDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"distance is {Math.Round(dis, 2)}");

//=============== Задача 23. ===========================
/*
Напищите программу, которая принимает на вход чисо (N) 
и выдает таблицу кубов чисел от 1 до N
3-> 1, 8, 27
5-> 1, 8, 27, 64, 125
*/

/*
1. Запросить у пользователя, число больше 0
2. Перебрать все числа от 1 до введеного числа
3. Каждое число возвести в третью степень
4. Результат вывести в терминал
*/

int EnterNumber()
{
    Console.Write("Enter any number, more then zero: ");
    int enteredNumber = Convert.ToInt32(Console.ReadLine());
    return enteredNumber;
}

void QubeExponentiation(int number)
{
   double num = 0;
   if(number<1) Console.WriteLine("Entered number, less then 1.");
   else
   {
        for (int i = 1; i <= number; i++)
        {
            num = Math.Pow(i, 3);
            if(i == number) Console.Write($"{num} ");
            else
            {
                Console.Write($"{num}, ");
            }
        }
   }
}

int number = EnterNumber();
QubeExponentiation(number);
