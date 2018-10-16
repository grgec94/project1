using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StrService : BaseService<StrRole>
    {
        public override void AddSpecific(StrRole item)
        {
            item.Role = "str";
            Console.Write("Project: ");
            item.Project = Console.ReadLine();

            item.AutomatedTests = Helper.ParseBoolInput("AutomatedTests:");
        }

        public override void Display()
        {

        }
    }
}