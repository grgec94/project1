using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StrService : BaseService<StrRole>
    {
        public override void AddSpecific(StrRole item)
        {
            item.Role = "st";
            Console.Write("Project: ");
            item.Project = Console.ReadLine();
            Console.Write("AutomatedTests: ");
            item.AutomatedTests = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {

        }
    }
}