using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class CeoService : BaseService<CeoRole>
    {
        public override void AddSpecific(CeoRole item)
        {
            item.Role = "ceo";
            Console.Write("CEOYears: ");
            item.CeoYears = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            
        }
    }
}