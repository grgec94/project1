using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{ 

    public class RoleFactory
    {
        public RoleProperties Create(string roleName)
        {
            switch (roleName)
            {
                case Common.Roles.Ceo:
                    return new CeoRole();
                case Common.Roles.ProjectManager:
                    return new ProjectManagerRole();
                case Common.Roles.Developer:
                    return new DeveloperRole();
                case Common.Roles.Designer:
                    return new DesignerRole();
                case Common.Roles.SoftwareTester:
                    return new SoftwareTesterRole();
                default:
                    return new BaseEmployeeRole();
            }
        }
    }
}
