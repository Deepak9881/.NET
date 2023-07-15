namespace Humans;

public  class Person{
    public string fName{get;set;}
    public string lName{get;set;}


    public Person(){
        Console.WriteLine("In person default constructor");
    }

    public Person(string fname,string lName){
        Console.WriteLine("In person parameterized constructor");
        this.fName=fname;
      this.lName=lName;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine("Parent showdetails");
    }



    public override string ToString(){
        return base.ToString()+" FirstName: "+fName+" LastName: "+lName;
    }
}