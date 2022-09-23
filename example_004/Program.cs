Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Программисту пулий!!!");
}
else
{
    Console.Write("Норок - Шнурок! ");
    Console.WriteLine(username);
}