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
int RoomChange; //Variabel för att kolla om spelare är på rätt rum. Your room = 0 Hallway = 1 Living Room = 2 Kitchen = 3 Bathroom = 4
int book = 1;
int photo = 0;
bool obj1 = false;//Objektiv för att fixa sängen
bool obj2 = false;//Objektiv för att äta frukost
bool obj3 = false;//Objektiv för att vattna blommor
bool obj5 = false;//Objektiv för att kolla dörren

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
    System.Console.WriteLine("\nHello my name is " + Ranname + ".");
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
            
            System.Console.WriteLine("Is " + py + " actually your name? (Y/N)\n");
            yn = Console.ReadLine().ToLower();
            if (yn == "y" || yn == "yes")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("\nI see...");
                Thread.Sleep(1000);
                System.Console.WriteLine("Nevermind. Welcome to the game.");
                on2 = false;
                on1 = false;
                re = false;
            }
                else if (yn == "n" || yn == "no")
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("\nAlright, you can write it again.\n");
                on2 = false;
            }
            else
            {
                System.Console.WriteLine("\nPlease answer the question.\n");
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
            System.Console.WriteLine("Your room is now silent.\n");
            Thread.Sleep(2000);
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
            Thread.Sleep(500);
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
    RoomChange = 0;
    while (true)
    {
        string todo = Console.ReadLine().ToLower();
        todoCommand(todo);

//----------------------------------------------------------------------------------------------------Your room zone------------------------------------------------------------------------------------------------------------------------

        if ((todo == "go your room" || todo == "go to your room") && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou're already in \u001b[36myour room\u001b[0m.\n");
            continue;
        }
        else if ((todo == "go your room" || todo == "go to your room") && RoomChange != 0)
        {
            System.Console.WriteLine("\nYou go to \u001b[36myour room\u001b[0m.\n");
            RoomChange = 0;
            continue;
        }
        if (todo == "check your room" && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou look around your room\n");
            Thread.Sleep(1000);
            System.Console.WriteLine("Because of the size of the apartment you live in, your room is not very wide.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Next to you, your \u001b[36mbed\u001b[0m offers a place of rest, and a small \u001b[36mbookshelf\u001b[0m stands behind, filled with a collection of books.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Sometimes, your gaze lingers on the \u001b[36mdesk\u001b[0m positioned beside the small \u001b[36mbookshelf\u001b[0m.\n");
            continue;
        }
        if (todo == "check bed" && RoomChange == 0 && obj1 == true)
        {
            System.Console.WriteLine("\nYou're already made your \u001b[36mbed\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You don't need to do anything further.\n");
            continue;
        }
        else if (todo == "check bed" && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou stare at the little mess on your \u001b[36mbed\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You start make your \u001b[36mbed\u001b[0m...");
            Thread.Sleep(2000);
            System.Console.WriteLine("Done, all neat and tidy now.\n");
            obj1 = true;
            continue;
        }
        if (todo =="check bookshelf" && RoomChange == 0 && book > 3)
        {
            System.Console.WriteLine("\nYou've already found something.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You don't feel like trying to find a book anymore.\n");
            continue;
        }
        else if (todo == "check bookshelf" && RoomChange == 0 && book == 3)
        {
            System.Console.WriteLine("\nYou sweep a glance at the \u001b[36mbookshelf\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You try to find a book.");
            Thread.Sleep(3000);
            System.Console.WriteLine("After third time you some how made it.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You've found someone's \u001b[36mdiary\u001b[0m.\n");
            book++;
            continue;
        }
        else if (todo == "check bookshelf" && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou sweep a glance at the \u001b[36mbookshelf\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("You try to find a book.");
            Thread.Sleep(3000);
            System.Console.WriteLine("Nothing seems interesting, you decide to give up.\n");
            book++;
            continue;
        }
        if(todo == "check desk" && RoomChange == 0)
        {
            System.Console.WriteLine("\nYou look at the table.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Except the alarm, there isn't much on your \u001b[36desk\u001b[0m.");
            Thread.Sleep(2000);
            System.Console.WriteLine("Just a lamp and a \u001b[36mphotograph\u001b[0m of someone.\n");
            continue;
        }
        if (todo == "check photograph" && RoomChange == 0 && photo > 0)
        {
            System.Console.WriteLine("\nYou've already checked it.\n");
            continue;
        }
        else if (todo == "check photograph" && RoomChange == 0)
        {
            Console.WriteLine("\nYou take a closer look at the \u001b[36mphotograph\u001b[0m.");
            Thread.Sleep(2000);
            Console.WriteLine("The picture itself looks a bit blurry.");
            Thread.Sleep(1000);
            Console.WriteLine("Still, you can see that there is a person in the picture.");
            Thread.Sleep(2000);
            Console.WriteLine("According to the attire, she seems to be a woman in young adulthood.");
            Thread.Sleep(2000);
            Console.WriteLine("However, no matter how hard you try, you can't specify who she is.");
            Thread.Sleep(2000);
            Console.WriteLine("You look at the bottom of the picture.\n");
            Thread.Sleep(1000);
            Console.Write("There is text on it:");
            Thread.Sleep(2000);
            Console.WriteLine("'Don't give up.'\n");
            Thread.Sleep(1000);
            Console.WriteLine("You're not sure what it means, so you put the \u001b[36mphotograph\u001b[0m back where it should be.\n");
            photo++;
            continue;
        }
//----------------------------------------------------------------------------------------------------hallway zone------------------------------------------------------------------------------------------------------------------------

        if ((todo == "go hallway" || todo == "go to hallway") && RoomChange == 1)
        {
            System.Console.WriteLine("\nYou're already in \u001b[36mhallway\u001b[0m.\n");
            continue;
        }
        else if ((todo == "go hallway" || todo == "go to hallway") && RoomChange != 1)
        {
            System.Console.WriteLine("\nYou go to the \u001b[36mhallway\u001b[0m.\n");
            RoomChange = 1;
            continue;
        }
        if (todo == "check hallway" && RoomChange == 1)
        {
            System.Console.WriteLine("\nYou look at the \u001b[36mhallway\u001b[0m.\n");
            Thread.Sleep(1000);
            System.Console.WriteLine("You used to fantasize that this hallway could be long, endless.");
            Thread.Sleep(2000);
            System.Console.WriteLine("Until you realize that it's too small to be endless.");
            Thread.Sleep(1000);
            System.Console.WriteLine("At the end of the hallway, there is just an \u001b[36mentry door\u001b[0m and wardrobe.\n");
            Thread.Sleep(2000);
            System.Console.WriteLine("Wait, why is the wardrobe here in the \u001b[36mhallway\u001b[0m?\n");
            continue;
        }

        if (todo == "check entry door" && RoomChange == 1 && obj5 == true)
        {
            System.Console.WriteLine("\nYou've already check the \u001b[36mentry door\u001b[0m.\n");
            continue;
        }
        else if (todo == "check entry door" && RoomChange == 1)
        {
            System.Console.Write("\nYou check the \u001b[36mentry door\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            System.Console.Write("It's locked,");
            Thread.Sleep(2000);
            System.Console.WriteLine("as usual.\n");
            obj5 = true;
            continue;
        }

//----------------------------------------------------------------------------------------------------Living room zone------------------------------------------------------------------------------------------------------------------------

        if ((todo == "go living room" || todo == "go to living room") && RoomChange == 2)
        {
            System.Console.WriteLine("\nYou're already in \u001b[36mliving room\u001b[0m.\n");
            continue;
        }
        else if ((todo == "go living room" || todo == "go to living room") && RoomChange != 2)
        {
            System.Console.WriteLine("\nYou go to \u001b[36mlivning room\u001b[0m.\n");
            RoomChange = 2;
            continue;
        }
        if (todo == "check living room" && RoomChange == 2)
        {
            System.Console.WriteLine("\nYou look around the \u001b[36mliving room\u001b[0m.\n");
            Thread.Sleep(1000);
            System.Console.WriteLine("This room is slightly larger than \u001b[36myour room\u001b[0m.");
            Thread.Sleep(1000);
            System.Console.WriteLine("There is a medium-sized flat-screen \u001b[36mTV\u001b[0m and a soft \u001b[36msofa\u001b[0m to sit and watch \u001b[36mTV\u001b[0m on.");
            Thread.Sleep(2000);
            System.Console.WriteLine("By the window, there is a small \u001b[36mflower\u001b[0m bed with different types of \u001b[36mflower\u001b[0ms mixed in it.");
            Thread.Sleep(2000);
            System.Console.WriteLine("Light coming through the window makes the room look warm.\n");
            continue;
        }


        
        
    





        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        if ((todo == "check your room" && RoomChange != 0)||
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
    Thread.Sleep(1000);

    System.Console.WriteLine("Make the bed.\nEat breakfast.\nWater the flowers.\nShower.\nCheck the entry door.\n");
}