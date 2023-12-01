using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.OutputEncoding = System.Text.Encoding.UTF8;


//----------------------------------------------------------------------------------------------------Var zone------------------------------------------------------------------------------------------------------------------------

string yn;
string py;
bool on2;
bool on1;
bool re;
int RoomChange; //Int för att kolla om spelare är på rätt rum. Your room = 0 Hallway = 1 Living Room = 2 Kitchen = 3 Bathroom = 4

//----------------------------------------------------------------------------------------------------Code zone------------------------------------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("_________________________________________________________\n");
System.Console.WriteLine("Warning: Do not press any key while dialog is processing.");
Console.WriteLine("_________________________________________________________");
Console.ResetColor();





re = true;
while(re == true)
{
    
    List<string> names = new List<string>() {"Martin", "Lena","Nicholas", "Christian"};
    names.Add("Micke");
    names.Add("Yoko");
    names.Add("Lucas");
    names.Add("Sebastian");
    names.Add("Steve");

    Random generator = new Random(); 

    int r = generator.Next(names.Count);

    string Ranname = names[r];

    Thread.Sleep(3000);
    System.Console.WriteLine();
    System.Console.WriteLine("Hello my name is " + Ranname + ".");
    Thread.Sleep(1000);
    System.Console.WriteLine("From now on, I'll be your narrator.");
    Thread.Sleep(2000);
    System.Console.WriteLine("Please, let me know your name.\n");
    on1 = true;

    while (on1 == true)
    {
        py = Console.ReadLine();

        if (py == "" || py == " ")
        {
            processing();
            
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Prossesing Failed!");
            Thread.Sleep(1000);
            System.Console.WriteLine("Sorry, your name can't being empty.\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            continue;
        }
        else if (py == Ranname)
        {
            processing();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Prossesing Failed!");
            Thread.Sleep(1000);
            System.Console.WriteLine("To reduce the confusing condition. I don't recommend you to use the same name as narrator.\n");
            Console.ResetColor();
            continue;
        }
        else if (names.Contains(py))
        {
            processing();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                
                Console.WriteLine("Processing Error Code:666");
                
            }
            System.Console.WriteLine("There was some error about your name. Please use another name instead.\n");
            Console.ResetColor();
            continue;
            
            
        }
        else if (py == "restart" || py == "Restart")
        {
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("System is restarting...");
            Console.ResetColor();
            on2 = false;
            on1 = false;
        }
        else
        {
            processing();
            if (ContainsBadWord(py))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Prossesing Failed!");
                Thread.Sleep(1000);
                System.Console.WriteLine("The name contains some sensitive words. Please write your name again.\n");

                Console.ResetColor();
                continue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Processing Complete.\n");
                Console.ResetColor();
                Thread.Sleep(3000);
                on2 = true;
            }
        }
        

        while(on2 == true)
        {
            
            System.Console.WriteLine("Is " + py + " actually your name? (Y/N)");
            yn = Console.ReadLine().ToLower();
            if (yn == "y" || yn == "yes")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("I see...");
                Thread.Sleep(1000);
                System.Console.WriteLine("Nevermind. Welcome to the game.");
                on2 = false;
                on1 = false;
                re = false;
            }
                else if (yn == "n" || yn == "no")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Alright, you can write it again.\n");
                on2 = false;
            }
            else
            {
                System.Console.WriteLine("Please answer the question.\n");
                continue;
            }
            
        }

    }


    if (re == false)
    {
        Thread.Sleep(1000);
        System.Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        loading();
        System.Console.WriteLine("Complete.\n");
        Console.ResetColor();
        Thread.Sleep(1000);
    }
    else if (re == true)
    {
        continue;
    }

    System.Console.WriteLine("The first light of day crept through the window, casting a soft glow on your face.");
    Thread.Sleep(3000);
    System.Console.WriteLine("The song of the welcoming morning kept playing loudly through your right ear.");
    Thread.Sleep(2000);
    System.Console.WriteLine("You slightly opened your eyes, and...");
    System.Console.WriteLine("HINT: type 'turn off the alarm' \n");
    while(true)
    {
        string alarm = Console.ReadLine();

        if (alarm == "turn off the alarm" || alarm == "turn off alarm")
        {
            System.Console.WriteLine("You turned off the alarm.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You room is now silent.\n");
            break;
        }
        else if (alarm.Contains("alarm"))
        {
            System.Console.WriteLine("You stare at the alarm.");
            Thread.Sleep(1000);
            System.Console.WriteLine("The sound continues playing loundy.");
            Thread.Sleep(1000);
            System.Console.WriteLine("What are you going to do with it?\n");
            continue;
        }
        else
        {
            System.Console.WriteLine("You are annoyed by the alarm sound.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Try to come up what you can do.\n");
            continue;
        }
    }
    System.Console.WriteLine("You forced your upper body to go up into a sitting position");
    Thread.Sleep(2000);
    System.Console.WriteLine("You stare into the void for 15 minutes until you realize your task for today.");
    Thread.Sleep(2000);
    System.Console.WriteLine("HINT: type 'task' or 't' to check your objectives.\n");

    while(true)
    {
        string task1 = Console.ReadLine().ToLower();
        
        if (task1 == "task" || task1 == "t")
        {
            task();
            System.Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            break;
        }
        else
        {
            System.Console.WriteLine("please follow the hint.");
            continue;
        }

    }
    System.Console.WriteLine("\nNow you have learned how to check the task.");
    Thread.Sleep(1000);
    System.Console.WriteLine("You get up from the bed into a standing position in \u001b[36myour room\u001b[0m.");
    Thread.Sleep(1000);
    System.Console.WriteLine("You live in the small apartment, which includes \u001b[36mhallway\u001b[0m, \u001b[36mliving room\u001b[0m, \u001b[36mkitchen\u001b[0m, and \u001b[36mbathroom\u001b[0m.");
    Thread.Sleep(2000);
    System.Console.WriteLine("All those texts highlighted in \u001b[36mcyan\u001b[0m mean you can type words to interact with them.");
    Thread.Sleep(1000);
    System.Console.WriteLine("The words you can use for now are: \u001b[36mgo\u001b[0m, and \u001b[36mcheck\u001b[0m.");
    Thread.Sleep(2000);
    System.Console.WriteLine("Now you are pondering what you are going to do.\n");
    while (true)
    {
        string todo = Console.ReadLine().ToLower();
        todoCommand(todo);
        RoomChange = 0;
        if (todo == "check your room" && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou checked your room\n");
            Thread.Sleep(1000);
            System.Console.WriteLine("Because of the size of the apartment you live in, your room is not very wide.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Next to you, your \u001b[36mbed\u001b[0m offers a place of rest, and a small \u001b[36mbookshelf\u001b[0m stands behind, filled with a collection of books.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Sometimes, your gaze lingers on the \u001b[36mdesk\u001b[0m positioned beside the small \u001b[36mbookshelf\u001b[0m.\n");
            continue;
        }
        else if ((todo == "check your room" && RoomChange != 0)||
                (todo == "check hallway" && RoomChange != 1)||
                (todo == "check living room" && RoomChange != 2)||
                (todo == "check kitchen" && RoomChange != 3)||
                (todo == "check bathroom" && RoomChange != 4))
        {
            System.Console.WriteLine("You ask youself: How can I check if I am not there?\n");
            continue;
        }
        else
        {
            Console.WriteLine("You are wondering what to do.\n");
            continue;
        }
        
    }  
    


}   


















//----------------------------------------------------------------------------------------------------Functions zone------------------------------------------------------------------------------------------------------------------------





static bool ContainsBadWord(string name)
{
    string[] badWords = { "fuck", "slut", "pussy","dick","gay","cum","cunt","bitch" };
    foreach (var word in badWords)
    {
        if (name.ToLower().Contains(word.ToLower()))
        {
            return true;
        }
    }

    return false;
}

static void processing()
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine();
    System.Console.WriteLine("System is processing...");
    Console.ResetColor();
    Thread.Sleep(2000);
}

static void loading()
{
     Console.Write("Loading");

        
    for (int i = 0; i < 3; i++)
    {
        Console.Write(".");
        Thread.Sleep(1000); 
    }
}
static void todoCommand(string doit)
{
    switch (doit)
    {
            case "task":
            case "t":
                task();
                break;

            case "go":
                Console.WriteLine("You are still unsure where to go.");
                break;

            case "check":
                Console.WriteLine("You checked the air, but there was nothing unusual.");
                break;
            
    }
}

static void task()
{
    System.Console.WriteLine("Things you need to do:\n");
    
    System.Console.WriteLine("Make the bed.\nEat breakfast.\nWater the flowers.\nShower.\nCheck the entry door.\n");
}