namespace Humans;


public class Student:Person{
    public readonly int i;
    public string school_Name { get; set; }
    public int marks { get; set; }

    public Student()  {
       i = 20;
        Console.WriteLine("In student default constructor"); 
    }
     
    public Student(string fname,string lname,string sname,int marks) : base(fname, lname)
    {
        Console.WriteLine("In student parameterized constructor");
        this.school_Name = sname;
        this.marks = marks;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Student ShowDetails");
    }

    public override string ToString() { 
        return base.ToString()+" SchoolName "+this.school_Name+" marks "+this.marks;
            }


}