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
            Console.Write("IsStudent: ");
            item.IsStudent = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {

        }
    }
}