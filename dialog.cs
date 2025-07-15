const int fastDialaogDelay = 30;
const int slowDialogDelay = 500;

PrintDialog("Can I have this?", fastDialaogDelay);
Console.ReadLine();
PrintDialog("No", slowDialogDelay);

void PrintDialog(string text, int delayMilliseconds)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(delayMilliseconds);
    }
    Console.WriteLine();
}
