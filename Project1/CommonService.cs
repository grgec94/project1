using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class CommonService : BaseService<RoleProperties>
    {

        public CommonService(string role) : base(role)
        {
        }

        public void FindAll()
        {

        }
        
        public void Get()
        {

        }
        public void Remove(string removeLastName)
        {
            Storage.Instance.Remove(removeLastName);
        }

        protected override RoleProperties AddSpecific(RoleProperties item)
        {
            throw new NotImplementedException();
        }

        protected override void DisplayList(IEnumerable<RoleProperties> list)
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(RoleProperties model)
        {
            throw new NotImplementedException();
        }
    }
}
