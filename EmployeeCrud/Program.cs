using System.Collections.Generic;
using EmployeeCrud;

Employee e=new Employee(10,"Deepak",15151);
Employee e1=new Employee(11,"Ashish",23561);
Employee e2=new Employee(12,"Gaurav",115151);
Employee e3=new Employee(13,"Shubham",815151);

EmployeeCruds ec=new EmployeeCruds();
ec.AddEmployee(e);
ec.AddEmployee(e1);
ec.AddEmployee(e2);
ec.AddEmployee(e3);
List<Employee> elist= ec.DisplayAll();

int count=0;
foreach(Employee emp in elist){
    
    Console.WriteLine(emp);
}



ec.Delete(10);
Console.WriteLine();
foreach(Employee emp in elist){
    Console.WriteLine(emp);
}
Console.WriteLine();
Console.WriteLine("Enter the id to be modified");
int id=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the updated name");
string name=Console.ReadLine();
ec.ModifyEmp(id,name);
Console.WriteLine();
foreach(Employee emp in elist){
    Console.WriteLine(emp);
}