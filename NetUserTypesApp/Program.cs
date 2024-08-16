Employee employee = new Employee();


employee.name = "Bobby";
employee.age = 29;

employee.Print();


var employee1 = new Employee();
Employee employee2 = new();


class Employee
{
    public string name;
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
}