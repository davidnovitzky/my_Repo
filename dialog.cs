PrintDialog("Can I have this?", 20);
Console.ReadLine();
PrintDialog("No", 1000);
    
void PrintDialog(string text, int delayMilliseconds)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(delayMilliseconds);
    }
    Console.WriteLine();
