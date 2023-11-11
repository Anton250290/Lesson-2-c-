// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

 Console.WriteLine("Введите трёхзначное положительное число");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num < 100 || num > 999)
     {
         Console.WriteLine("Третьей цифры нет");
     }
  else num = num % 10;
      {
          Console.WriteLine($"{num}");
      }



