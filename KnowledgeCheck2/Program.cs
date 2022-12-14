using static System.Console;
namespace KnowledgeCheck2;

class Program
{
    static void Main(string[] args)
    {
        Title = "Pumpkin Log";
        //BackgroundColor = ConsoleColor.Black;
        //ForegroundColor = ConsoleColor.Magenta;

        WriteLine("How many pumpkins do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());
        WriteLine("");

        var recordList = new List<Pumpkin>();
        
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var pumpkin = new Pumpkin();

            Write("Give your pumpkin a name: ");
            pumpkin.Name = ReadLine();
                        
            Write($"Tell us a little about {pumpkin.Name}: ");
            pumpkin.Description = ReadLine();
            
            Write($"Is {pumpkin.Name} carved? Enter 'y' for YES and 'n' for NO: ");
            string carved = ReadLine();
            while ((carved != "y") && (carved != "n"))
            {
                Write("Please enter 'y' for YES and 'n' for NO: ");
                carved = ReadLine();
            }
            if (carved == "y")
            {
                pumpkin.IsCarved = true;
            }
            else
            {
                pumpkin.IsCarved = false;
            }
            WriteLine("");

            recordList.Add(new Pumpkin() { Name = pumpkin.Name, Description = pumpkin.Description, IsCarved = pumpkin.IsCarved });
        }

        //Print out the list of records using Console.WriteLine()
        foreach (var pumpkin in recordList)
        {
            WriteLine($"Pumpkin name: {pumpkin.Name}");
            WriteLine($"Description: {pumpkin.Description}");
            WriteLine($"Is {pumpkin.Name} carved? {pumpkin.IsCarved}.");
            WriteLine(" ");
        }

        var boo = new Pumpkin();
        boo.Boo();

        WriteLine("Press any key to exit...");
        ReadKey();
    }

}
