using static System.Console;
namespace KnowledgeCheck2;

class Program
{
    static void Main(string[] args)
    {      
        WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Pumpkin>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var pumpkin = new Pumpkin();
            Write("Give your pumpkin a name: ");
            pumpkin.Name = ReadLine();
            WriteLine("");
            
            Write("Enter a description of your pumpkin: ");
            pumpkin.Description = Console.ReadLine();
            WriteLine("");

            recordList.Add(new Pumpkin() { Name = pumpkin.Name, Description = pumpkin.Description });
        }

        //Print out the list of records using Console.WriteLine()
        foreach (var pumpkin in recordList)
        {
            WriteLine($"Pumpkin name: {pumpkin.Name}");
            WriteLine($"Description: {pumpkin.Description}");
        }


        WriteLine("Press any key to exit...");
        ReadKey();
    }

}
