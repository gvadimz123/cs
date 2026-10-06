using System;

class Box<T>
{
    private T value;

    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.SetValue(42);
        Console.WriteLine("int: " + intBox.GetValue());

        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Hello, World!");
        Console.WriteLine("string: " + stringBox.GetValue());

        Box<Student> studentBox = new Box<Student>();
        studentBox.SetValue(new Student("Alex"));
        Console.WriteLine("Student: " + studentBox.GetValue());

        Console.ReadKey();
    }
}
