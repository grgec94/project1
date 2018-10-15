using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class DsnrService : BaseService<DsnrRole>
    {
        public override void AddSpecific(DsnrRole item)
        {
            item.Role = "dsnr";
            Console.Write("Project: ");
            item.Project = Console.ReadLine();
            Console.Write("CanDraw: ");
            item.CanDraw = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Display()
        {

        }
    }
}