using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.OutputEncoding = System.Text.Encoding.UTF8;






List<string> names = new List<string>() {"Martin", "Lena","Nicholas", "Christian"};
names.Add("Micke");
names.Add("Yoko");
names.Add("Lucas");
names.Add("Sebastian");
names.Add("Steve");

Random generator = new Random(); 

int r = generator.Next(names.Count);

string Ranname = names[r];

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("_________________________________________________________");
Console.WriteLine("");
System.Console.WriteLine("Warning: Do not press any key when dialog is processing.");
Console.WriteLine("_________________________________________________________");
Console.ResetColor();
System.Console.WriteLine();
Thread.Sleep(3000);


System.Console.WriteLine("Hello my name is " + Ranname + ".");
Thread.Sleep(1000);
System.Console.WriteLine("From now on, I'll be your narrator.");
Thread.Sleep(2000);
System.Console.WriteLine("Please, let me know your name.");
string py;
while (true)
{
    py = Console.ReadLine();

    if (py == "" || py == " ")
    {
        System.Console.WriteLine("Sorry, I can't let your name being empty.");
        Thread.Sleep(2000);
        System.Console.WriteLine("Would you kindly write it again?");
        System.Console.WriteLine();
        continue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine();
        System.Console.WriteLine("System is processing...");
        Console.ResetColor();
        if (ContainsBadWord(py))
        {
            System.Console.WriteLine("Prossed");
            continue;
        }
        else
        {
            System.Console.WriteLine("Processing complete!");
            break;
        }


        

    }
}

bool ContainsBadWord(string name)
{
    string[] badWords = { "fuck", "slut", "pussy","dick" };

    foreach (var word in badWords)
    {
        if (name.ToLower().Contains(word.ToLower()))
        {
            return true;
        }
    }

    return false;
}






Thread.Sleep(3000);
System.Console.WriteLine("Is " + py + " actually your name? (Y/N)");
    




Console.ReadLine();


