using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
       // protected Storage Storage = new Storage();

        public void Add()
        {
            T model = new T();
           
            Console.WriteLine("First Name:");
            model.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            model.LastName = Console.ReadLine();

            model.Age= Helper.ParseUserInput("Age: ");

            AddSpecific(model);
            Storage.Instance.Add(model);
        }
        public abstract void AddSpecific(T item);
        public abstract void Display();
    }
   // public class SpecifiicClasName : BaseService<Model>

}
