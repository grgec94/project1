using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Available commands: Add, Remove, Display, List, < role_name > List");



              Console.WriteLine("Role:");
              string Role = Console.ReadLine();

              Console.WriteLine("Frst Name:");
              string FrstName = Console.ReadLine();

              Console.WriteLine("Last Name:");
              string LastName = Console.ReadLine();

              Console.WriteLine("Age:");
              string Age = Console.ReadLine();
              */
            Console.WriteLine("Available commands: Add, Remove, Display, List, <role_name>List");
            Console.Write("Command: ");
        }
        public STRRole stRole = new STRRole();
        public DEVRole devRole = new DEVRole();
        public CEORole ceoRole = new CEORole();
        public DSNRRole dsnRole = new DSNRRole();
        public PMRole pmRole = new PMRole();

    } 
}