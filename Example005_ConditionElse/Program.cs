﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Здорова заебал");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}