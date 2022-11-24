// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
//1 ввести цифру от пользовотеля
//2 определить будние дни (1-5) и выходные (6,7)
//3 проверить подходит ли значение пользователя  (1-7)
//4 проверить значение пользователя
//4 вывод сообщения

//Console.WriteLine("Введите цифру");
//string dayNumber = Console.ReadLine();
//string dayNumber = Convert.ToString(Console.ReadLine());
int dayNumber = 13;

if(1 <= dayNumber & dayNumber <= 5)
{
  Console.WriteLine("Будний день");
}
if(6 <= dayNumber & dayNumber <= 7)
{
  Console.WriteLine("Выходной день");
}
if(dayNumber > 7)
{
  Console.WriteLine("Введены некорректные данные");
}