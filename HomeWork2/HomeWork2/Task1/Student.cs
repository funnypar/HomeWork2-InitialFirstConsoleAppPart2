namespace HomeWork2.Task1
{
    public class Student
    {
        // We do not need to define "age" and "name" ! The propeties create them in backgrond and manage them
        // And we can easily write logics for them
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}