using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StrService : BaseService<STRRole>
    {
        public override void AddSpecific(STRRole item)
        {
            STRRole model = new STRRole();
            Console.Write("PROJECT: ");
            model.Project = Console.ReadLine();
            Console.Write("AutomatedTests: ");
            model.AutomatedTests = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}