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

                    var ndceo = Storage.Instance.MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();

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
                        case "st":
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
                    Console.WriteLine("Available commands: Add, Remove, Display, List, Help");
                }
                else if (command.ToLower() == "remove")
                {
                    Console.Write("Enter last name of employee you want to remove from list: ");
                    var removelastname = Console.ReadLine();

                    var remlastname = Storage.Instance.MyList.Where(roles => roles.LastName == removelastname).FirstOrDefault();
                    Storage.Instance.MyList.Remove(remlastname);
                }
                else if (command.ToLower() == "display")
                {
                    foreach (RoleProperties displaylist in Storage.Instance.MyList)
                    {
                     Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", displaylist.Role, displaylist.FirstName, displaylist.LastName, displaylist.Age);
                    }
                }
            }
        }

    } 
}