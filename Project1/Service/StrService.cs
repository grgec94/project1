using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class StrService : BaseService<StrRole>
    {
        public StrService() : base(Common.Roles.SoftwareTester)
        {
        }

        protected override StrRole AddSpecific(StrRole model)
        {
            bool valid;
            do
            {
                Console.WriteLine("What project is he/she working on?");
                valid = Console.ReadLine().IsValidString(out var project);
                model.Project = project;
            } while (!valid);

            do
            {
                Console.WriteLine("Is he/she using automated tests?");
                valid = Console.ReadLine().IsValidBool(out var usesAutomatedTests);
                model.UsesAutomatedTests = usesAutomatedTests;
            } while (!valid);

            return model;
        }

        protected override void DisplayList(IEnumerable<StrRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        protected override void DisplaySingle(StrRole model)
        {
            Console.WriteLine($"{model.Roles}: {model.LastName} {model.FirstName}, {model.Age}, works on {model.Project} project and {(model.UsesAutomatedTests ? "is" : "isn't")} using automated tests");
        }
    }
}