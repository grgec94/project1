using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DevService : BaseService<DevRole>
    {
        public override void AddSpecific(DevRole item)
        {
           // DevRole model = new DevRole();
            Console.Write("Projects: ");
            item.Projects = Console.ReadLine();
            Console.Write("IsStudent: ");
            item.IsStudent = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}