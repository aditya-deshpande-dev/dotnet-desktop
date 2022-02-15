// See https://aka.ms/new-console-template for more information
Console.WriteLine("Process started.");
Console.WriteLine("Progress...");
ShowProgress(757, 1000);

Console.Read();
void ShowProgress(double complete, double total)
{
    Console.CursorLeft = 2;
    Console.CursorTop = 5;

    double perc = (complete / total) * 100;
    Console.BackgroundColor = ConsoleColor.Green;
    for (int i = 0; i < 100; i++)
    {
        if (i < perc)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(".");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(".");
        }
    }
    Console.ResetColor();
    Console.Write(" (" + perc + "%) " + complete + "/" + total);
}