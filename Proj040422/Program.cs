// See https://aka.ms/new-console-template for more information
using Model;

Console.WriteLine("Hello, World!");

Client c1 = new Client()
{

    Id = 1,
    Name = "teste",
    Telephone = "16 9999 9999"

};
Client c2 = new Client()
{

    Id = 2,
    Name = "teste2",
    Telephone = "16 8888 8888"

};
Employee e1 = new Employee()
{

    Id = 1,
    Name = "emp 1",
    Telephone = "16 7777 7777"

};
Employee e2 = new Employee()
{

    Id = 2,
    Name = "emp 2",
    Telephone = "16 8888 8888"

};


List<Client> Clients =  new List<Client>();
List<Employee> Employees = new List<Employee>(); 

Clients.Add(c1);
Clients.Add(c2);
Employees.Add(e1);
Employees.Add(e2);

Hotel hotel = new Hotel()
{
    Client = Clients,
Employee = Employees

};

Console.WriteLine(hotel.getClient());
Console.WriteLine(hotel.getEmployee());