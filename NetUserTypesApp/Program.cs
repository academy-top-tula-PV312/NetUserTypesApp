using NetUserTypesApp;
using System.ComponentModel;

Employee employee = new Employee();

employee.name = "Bobby";
employee.age = 29;


employee.Print();

Employee bob = new Employee("Bobby", 26);

(string n, int a) = bob;
Console.WriteLine(n);
Console.WriteLine(a);

ClPerson cperson1 = new() { name = "Bob", age = 27 };
ClPerson cperson2 = cperson1;
cperson2.name = "Leo";
Console.WriteLine(cperson1.name);

StPerson sperson1 = new() { name = "Bob", age = 27 };
StPerson sperson2 = sperson1;
sperson2.name = "Leo";
Console.WriteLine(sperson1.name);


RcPerson rperson1 = new() { name = "Bob", age = 27 };
RcPerson rperson2 = rperson1;
rperson2.name = "Leo";
Console.WriteLine(rperson1.name);

void Functuion()
{
    i = 10;
}


class Employee
{
    public string name;
    public string address;
    public int age;

    public void Print()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    public Employee() { }

    public Employee(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Employee(string name) : this(name, 0) { }
    public Employee(int age) : this("Anonim", age) { }

    public void Deconstruct(out string name, out int age)
    {
        name = this.name;
        age = this.age;
    }
}

class ClPerson
{
    public string name;
    public int age;
}

struct StPerson
{
    public string name;
    public int age;
    public ClPerson parent;
}

record RcPerson
{
    public string name;
    public int age;
}