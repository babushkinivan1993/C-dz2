// Task10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// int TheSecond(int numb)
// {
//     int tens = numb / 10;
//     int cifra = tens%10;
//     return cifra;
// }
// Console.WriteLine("Введите трёхзначное число  ");
// int n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1000 && n > 99) Console.WriteLine("Вторая цифра вашего числа " + TheSecond(n));
//     else Console.WriteLine("Введено не трёхзначное число");



// Task13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int TheThird(int numb)
// {
//    int hundreds = numb / 100;
//    if (hundreds >0)
//    {
//     while (hundreds >9)
//     {
//         numb = numb / 10;
//         hundreds = numb / 100;
//     }
//     int cifra = numb%10;
//     return cifra;
//    } 
// else return -1;

// }
// Console.WriteLine("Введите число  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Третья цифра вашего числа: " + TheThird(n));



// Task15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// bool WeekEnd(int day)
// {
//     if (day>5 && day<8) return true;
//     else return false;
// }
// Console.WriteLine("Введите номер дня неделе, если ");
// Console.WriteLine("1 - Понедельник");
// Console.WriteLine("2- Вторник ");
// Console.WriteLine("3- Среда ");
// Console.WriteLine("4 - Четверг ");
// Console.WriteLine("5 - Пятница ");
// Console.WriteLine("6 - Суббота");
// Console.WriteLine("7 - Воскресенье");
// int d = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(d + " день недели - выходной!");
// Console.WriteLine("Это - " + WeekEnd(d));