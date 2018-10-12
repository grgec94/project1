using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DsnrService : BaseService<DSNRRole>
    {
        public override void AddSpecific(DSNRRole item)
        {
            DSNRRole model = new DSNRRole();
            Console.Write("Project: ");
            model.Project = Console.ReadLine();
            Console.Write("CanDraw: ");
            model.CanDraw = Console.ReadLine();
        }

        public override void Display()
        {

        }
    }
}