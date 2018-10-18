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
            item.CeoYears = Helper.ParseUserInput("Ceo Years:");

        }
            public bool CheckIfCeoExist(RoleProperties ceoExistanceCheck)
            {
            bool ceoExistance;
                if (ceoExistanceCheck == null)
                {
                    ceoExistance = false;
                }
                else
                {
                    ceoExistance = true;
                }
                return ceoExistance;
            }

        
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}