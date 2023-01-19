// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь,
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33];

Console.Clear();
Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32 (Console.ReadLine());
int n1 = Convert.ToInt32 (Console.ReadLine());
int n2 = Convert.ToInt32 (Console.ReadLine());
int n3 = Convert.ToInt32 (Console.ReadLine());
int n4 = Convert.ToInt32 (Console.ReadLine());
int n5 = Convert.ToInt32 (Console.ReadLine());
int n6 = Convert.ToInt32 (Console.ReadLine());
int n7 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"[{n},{n1},{n2},{n3},{n4},{n5},{n6},{n7}]");

