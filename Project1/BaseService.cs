using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        protected Storage storage = new Storage();
        public void Add()
        {
            T model = new T();
            Console.WriteLine("Role:");
            model.Role = Console.ReadLine();

            Console.WriteLine("Frst Name:");
            model.FrstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            model.LastName = Console.ReadLine();

            Console.WriteLine("Age:");
            model.Age = Console.ReadLine();

            AddSpecific(model);
        }
        public abstract void AddSpecific(T item);
        public abstract void Display();
    }
}
