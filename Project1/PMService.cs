using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class PmService : BaseService<PMRole>
    {
        public override void AddSpecific(PMRole item)
        {
           PMRole model = new PMRole();
            Console.Write("Projects: ");
            model.Projects = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}