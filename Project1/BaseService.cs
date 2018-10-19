using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    public abstract class BaseService<T> where T : RoleProperties, new()
    {
        private readonly string Role;
        private readonly Storage storage;

        protected BaseService(string role)
        {
            Role = role;
        }
        public virtual void Add()
        {
            T model = new T();

            Console.WriteLine("First Name:");
            model.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            model.LastName = Console.ReadLine();

            model.Age = Helper.ParseUserInput("Age: ");

            AddSpecific(model);
            Storage.Instance.Add(model);
        }



        public IEnumerable<T> Find()
        {

            return Storage.Instance.Find(Role).Cast<T>();
        }

        protected abstract T AddSpecific(T item);
        protected abstract void DisplayList(IEnumerable<T> list);
        protected abstract void DisplaySingle(T model);
    }
    // public class SpecifiicClasName : BaseService<Model>

}
