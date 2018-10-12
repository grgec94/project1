using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DevService : BaseService<DEVRole>
    {
        public override void AddSpecific(DEVRole item)
        {
            DEVRole model = new DEVRole();
            Console.Write("Projects: ");
            model.Projects = Console.ReadLine();
            Console.Write("IsStudent: ");
            model.IsStudents = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}