Console.Clear();

//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

// int xa = 1, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");


Console.Clear();
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int div5 = num%10;
// int div1 = num/10000%10;
// int div4 = num/10%10;
// int div2 = num/1000%10;

// if (div5==div1||div4==div2) Console.WriteLine("да");
//  else Console.WriteLine("нет");


// Console.WriteLine("Введите число");
// int num1 = 5;
// int num2 = 2;

// if (num1 == 2 )
// {
    
//     Console.WriteLine("yes");
// }
// else if(num2 == 2)
// {
//     Console.WriteLine("yes2");
// }
// else
// {
//     Console.WriteLine("no");
// }


//  Console.WriteLine("Введите число");
// int num1 = 5;
// int num2 = 2;
// //  

// for (int i = 1; i< 5; i++) 
// {
//     Console.WriteLine(i);
// }


// 9. случайое число
//  Console.WriteLine("Введите число");
// int num = new Random().Next(10,100);
// int num1 = num % 10;
// int num2 = num / 10;
// if (num > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }
// Console.WriteLine(num);


// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//  Console.WriteLine("Введите число");
// int num = new Random().Next(100,999);
// int num1 = num%10;
// int num2 = num/100%10;
// Console.WriteLine(num);
// Console.Write(num2);
// Console.Write(num1);


// Stanislav N: 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

//  Console.WriteLine("Введите число");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число");
//  int num2 = Convert.ToInt32(Console.ReadLine());
// int div = ((num1%num2)&(num1%num2));

// if (div == 0){Console.WriteLine("yes");}
// else{Console.WriteLine($"no % {div}");}
 
 


// Stanislav N: 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//  Console.WriteLine("Введите число");
//  int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num%7;
// int num2 = num%23;


// // Console.WriteLine(div);
// if (num1 == 0 && num2 == 0)Console.WriteLine("yes");
// else Console.WriteLine("no");


// Stanislav N: 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет