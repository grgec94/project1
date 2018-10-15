using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class PmService : BaseService<PmRole>
    {
        public override void AddSpecific(PmRole item)
        {
            item.Role = "pm";
            Console.Write("Projects: ");
            item.Project = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}