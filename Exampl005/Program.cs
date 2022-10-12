Console.WriteLine("Ваше имя:");
string username = Console.ReadLine();
Console.WriteLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет Машка");
}
else
{
    Console.Write("Hi , ");
    Console.WriteLine(username);
}