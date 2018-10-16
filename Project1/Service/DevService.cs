using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DevService : BaseService<DevRole>
    {
        public override void AddSpecific(DevRole item)
        {
            item.Role = "dev";
            Console.Write("Projects: ");
            item.Projects = Console.ReadLine();
           
            item.IsStudent = Helper.ParseBoolInput("IsStudent:");
        }

        public override void Display()
        {

        }
    }
}