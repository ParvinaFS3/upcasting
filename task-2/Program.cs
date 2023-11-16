using System;

class Person
{
    private static int _counter = 0;
    private int _age;

    public int Age
    {
        get { return _age; }
    }

    public Person()
    {
        _counter++;
        _age = _counter;
    }
}

class Student : Person
{
    // Student class-ı Person class-ından törədiyindən, Age özəlliyini burada təkrar təyin etmək
    // lazım deyil. O, avtomatik olaraq Person class-ından miras alınacaq.
}

class Program
{
    static void Main()
    {
        Student tural = new Student();
        Console.WriteLine(tural.Age); // 1

        Student suleyman = new Student();
        Console.WriteLine(suleyman.Age); // 2

        Student gafar = new Student();
        Console.WriteLine(gafar.Age); // 3

        Student semed = new Student();
        Console.WriteLine(semed.Age); // 4
    }
}









