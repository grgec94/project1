﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project1
{
    public class EmployeeService
    {
        private readonly CommonService commonService;
        private readonly CeoService ceoService;
        private readonly PmService pmService;
        private readonly DeveloperService devService;
        private readonly DsnrService dsnrService;
        private readonly StrService strService;

        public EmployeeService()
        {
            commonService = new CommonService();
            ceoService = new CeoService();
            pmService = new PmService();
            devService = new DeveloperService();
            dsnrService = new DsnrService();
            strService = new StrService();
        }

        public void HandleAdd()
        {

            string role;
            do
            {
                Console.WriteLine("Select a role: (ceo, pm, dev, dsnr, st)");
                role = Console.ReadLine();

            } while (role != "ceo" && role != "pm" && role != "dev" && role != "dsnr" && role != "st");

            switch (role.ToUpper())
            {
                case Common.Roles.Ceo:
                    ceoService.Add();
                    break;
                case Common.Roles.ProjectManager:
                    pmService.Add();
                    break;
                case Common.Roles.Developer:
                    devService.Add();
                    break;
                case Common.Roles.Designer:
                    dsnrService.Add();
                    break;
                case Common.Roles.SoftwareTester:
                    strService.Add();
                    break;
            }
        }

        public void HandleRemove()
        {
            Console.WriteLine("Select employee to remove: (note: select by row number (e.g. '1')");
            var list = HandleDisplay();

            bool valid;
            int selection;
            do
            {
                Console.WriteLine($"Select a number between 1 and {list.Count()}");
                valid = Console.ReadLine().IsValidInt(out selection);

                if (selection < 1 || selection > list.Count())
                {
                    valid = false;
                    Console.WriteLine("Input out of range.");
                }

            } while (!valid);

            var toRemove = list.ElementAt(selection - 1);

            switch (toRemove.Roles)
            {
                case Common.Roles.Ceo:
                    ceoService.Remove(toRemove.Roles);
                    break;
                case Common.Roles.ProjectManager:
                    pmService.Remove(toRemove.Roles);
                    break;
                case Common.Roles.Developer:
                    devService.Remove(toRemove.Roles);
                    break;
                case Common.Roles.Designer:
                    dsnrService.Remove(toRemove.Roles);
                    break;
                case Common.Roles.SoftwareTester:
                    strService.Remove(toRemove.Roles);
                    break;
            }
        }

        public IEnumerable<RoleProperties> HandleDisplay()
        {
            var employeeList = commonService.FindAll().ToArray();

            for (int i = 0; i < employeeList.Length; i++)
            {
                Console.WriteLine($"#{i + 1}. {employeeList[i].LastName} {employeeList[i].FirstName} - {employeeList[i].Roles}");
            }

            return employeeList;
        }

        public void HandleList(string roleName)
        {
            switch (roleName)
            {
                case Common.Roles.Ceo:
                    ceoService.Find();
                    break;
                case Common.Roles.ProjectManager:
                    pmService.Find();
                    break;
                case Common.Roles.Developer:
                    devService.Find();
                    break;
                case Common.Roles.Designer:
                    dsnrService.Find();
                    break;
                case Common.Roles.SoftwareTester:
                    strService.Find();
                    break;
                case null:
                    pmService.Find();
                    dsnrService.Find();
                    devService.Find();
                    strService.Find();
                    break;
            }
        }
        public IEnumerable<RoleProperties> HandleLn()
        {
            Console.WriteLine("Select employee last name: ");
            string lastName = Console.ReadLine();
            var employeeList = commonService.FindAll().ToArray();
            var result = employeeList.Where(ln => ln.LastName == lastName).ToArray();

            if (result != null && result.Any())
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"#{i + 1}. {result[i].LastName} {result[i].FirstName} - {result[i].Roles}");

                }              
            }

            else
            {
                Console.WriteLine("Entered last name does not exist, type another");
            }
            return result;

        }
    }
}