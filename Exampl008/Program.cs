Console.Clear();
int count = 0;
while (count <10)
{
    int x = (new Random().Next(0,60));
    int y = (new Random().Next(0,20));
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    System.Threading.Thread.Sleep(15);
    count ++;
}
Console.SetCursorPosition(22, 22);
count = 0;
int yy = 1; //
while (yy < 20)
{
    while (count <30)
    {
        
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
                    Console.WriteLine("Enter pressed");
        
        }
        Console.SetCursorPosition(count, yy);
        Console.WriteLine("  ");
        count ++;
        Console.SetCursorPosition(count, yy);
        Console.WriteLine("OO");
        System.Threading.Thread.Sleep(20);
    }
    Console.SetCursorPosition(count, yy);
    Console.WriteLine("  ");
    count = 0;
    yy ++;
}
Console.SetCursorPosition(22, 22);