using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StrService : BaseService<StrRole>
    {
        public override void AddSpecific(StrRole item)
        {
          //  StrRole model = new StrRole();
            Console.Write("PROJECT: ");
            item.Project = Console.ReadLine();
            Console.Write("AutomatedTests: ");
            item.AutomatedTests = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}