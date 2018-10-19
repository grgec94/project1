using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public class CeoService : BaseService<CeoRole>
    {
        public CeoService():base("ceo")
        {
        }

        public override CeoRole Add()
        {
            var ceoList = Find();

            if (ceoList.Count() == 0)
            {
                base.Add();
            }
            else
            {
                Console.WriteLine(" There is already CEO");
            }
        }

        protected override AddSpecific(CeoRole item)
        {
            item.Role = "ceo";
            item.CeoYears = Helper.ParseUserInput("Ceo Years:");
        }
     

        public override void DisplayList(IEnumerable<CeoRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }
        protected override void DisplaySingle(CeoRole item)
        {
            Console.WriteLine($"{item.LastName} {item.FirstName}, {item.Age}, with {item.CeoYears} {(item.CeoYears <= 1 ? "year" : "years")} of experiance as CEO");
        }
    }
}