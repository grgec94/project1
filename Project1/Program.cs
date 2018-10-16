using System;
using System.Linq;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            CeoService ceoService = new CeoService();
            StrService stService = new StrService();
            PmService pmService = new PmService();
            DsnrService dsnService = new DsnrService();
            DevService devService = new DevService();

            
            Console.WriteLine("Available commands: Add, Remove, Display, List, Help");
            while (true)
            {
                Console.Write("Command: ");

                var command = Console.ReadLine();

                if (command.ToLower() == "add")
                {
                    Console.Write("Role: ");
                    var role = Console.ReadLine();

                   // var ndceo = Storage.Instance.MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();

                    switch (role.ToLower())
                    {
                        case "ceo":
                            if (ndceo == null)
                            {
                                ceoService.Add();
                            }
                            else
                            {
                                Console.WriteLine("There is already CEO.");
                            }
                            break;
                        case "pm":
                            pmService.Add();
                            break;
                        case "str":
                            stService.Add();
                            break;
                        case "dsn":
                            dsnService.Add();
                            break;
                        case "dev":
                            devService.Add();
                            break;
                    }
                }
                else if (command.ToLower() == "help")
                {
                    Console.WriteLine("Available commands: \n Add – used for adding new employee \n Remove – used for removing an existing employee \n" +
                        " Display – used to display all employees(including you!) with their basic info\n  List – used to display all employees(excluding you!) with their basic infop");
                }
                else if (command.ToLower() == "remove")
                {
                    Storage.Instance.Remove();
                }
                else if (command.ToLower() == "display")
                {
                    Storage.Instance.Display();
                }
            }
        }

    } 
}