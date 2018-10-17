using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public class Storage
    {
        protected static Storage instance;
        private Storage()
        {

        }
        public static Storage Instance
        {
            get
            {
                if (instance == null)
                    instance = new Storage();
                return instance;
            }
            
        }
        //private
        private List<RoleProperties> MyList = new List<RoleProperties>();

        public void Add(RoleProperties item)
        {
            MyList.Add(item);
        }

        public void Help(RoleProperties item)
        {
            Console.WriteLine("Available commands: \n Add – used for adding new employee \n Remove – used for removing an existing employee \n" +
                        " Display – used to display all employees(including you!) with their basic info\n  List – used to display all employees(excluding you!) with their basic infop");
        }

        public void Remove()
        {
            Console.Write("Enter last name of employee you want to remove from list: ");
            var removelastname = Console.ReadLine();

            var remlastname = Storage.Instance.MyList.Where(roles => roles.LastName == removelastname).FirstOrDefault();
            Storage.Instance.MyList.Remove(remlastname);
        }

        public void Display()
        {
            foreach (RoleProperties displaylist in Storage.Instance.MyList)
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", displaylist.Role, displaylist.FirstName, displaylist.LastName, displaylist.Age);
            }
        }
        public void List()
        {
            foreach (RoleProperties listItem in MyList.Where(item => item.Role != "ceo"))
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", listItem.Role,
                    listItem.FirstName, listItem.LastName, listItem.Age);
            }
        }
        public bool CheckIfCeoExist()
        {
            bool ceoExistance;
            var ceoExistanceCheck = MyList.Where(roles => roles.Role == "ceo").FirstOrDefault();
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
        public void RoleNameList()
        {
            Console.Write("Enter role name of employees you want to display: ");
            string roleName = Console.ReadLine();

            foreach (RoleProperties roleNameListItem in MyList.Where(item => item.Role == roleName))
            {
                Console.WriteLine("Role: {0}, First name: {1}, Last name: {2}, Age: {3}", roleNameListItem.Role,
                    roleNameListItem.FirstName, roleNameListItem.LastName, roleNameListItem.Age);
            }

        }
    }
}
