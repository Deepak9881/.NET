using System.Collections.Generic;
namespace EmployeeCrud
{
    public class Employee
    {
        public int empno{get;set;}
        public string ename{get;set;}
        public float sal{get;set;}

        public Employee(){}
        public Employee(int empno,string name,float sal){
            this.empno=empno;
            this.ename=name;
            this.sal=sal;
        }

        public Employee(int empno){
            this.empno=empno;
            this.ename=null;
            this.sal=0f;
        }

     public override string ToString(){
         return base.ToString()+" Empno: "+this.empno+" Ename: "+this.ename+" Salary: "+this.sal;
     }

    }

    public class EmployeeCruds{
        private List<Employee>elist=new List<Employee>();


        public void AddEmployee(Employee e){
            Console.WriteLine("inside add method"); 
            elist.Add(e);
        }

        public List<Employee> DisplayAll(){
           return elist;
        }
        public void Delete(int id)
        { Employee emp=null;
            foreach(Employee e in elist){
                if(e.empno==id){
                  elist.Remove(e);
                  break;
                }
            }
           
        }
    

    public void ModifyEmp(int id, string name){
        int count=0;
        foreach(Employee e in elist){
            if(e.empno==id){
                e.ename=name;
            }
           
        }
    }
}
}