using System;
using System.Collections.Generic;
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
        public List<RoleProperties> MyList = new List<RoleProperties>();

        public void Add(RoleProperties item)
        {
            MyList.Add(item);
        }

        public void Help(RoleProperties item)
        {
            Console.WriteLine("Available commands: Add, Remove, Display, List, Help");
        }

        public void Removep(RoleProperties item )
        {

        }

        public void Display(RoleProperties item)
        {

        }

        /*
         public void List(RoleProperties item)
        {

        }
        */

    }
}
