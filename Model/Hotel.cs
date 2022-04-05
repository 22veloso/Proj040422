using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hotel
    {
        public List<Client> Client { get; set; }
        public List<Employee> Employee { get; set; }


        public string getClient()
        {
            string clients = " ";
            foreach (var client in Client)
            {
                clients += "\nId: " + client.Id + " \nNome: " + client.Name;
            }
            return clients;
        }
        public string getEmployee()
        {
            string employees = " ";
            foreach (var employee in Employee)
            {
                employees += "\nId: " + employee.Id + " \nNome: " + employee.Name;
            }
            return employees;
        }
    }
}
