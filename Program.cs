
using System.Linq;

public class program
{
    public static void Main()
    {
        Myarray<student> students = new Myarray<student>()
        {
            new student{Id=3, Name="Anas"},
            new student{Id=4, Name="asad"},
            new student{Id=9, Name="Asmaa"},
            new student{Id=10, Name="saad"}
        };
        var result =
            students.where(s => s.Id > 7);
        foreach (var student in result)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }
        Console.WriteLine("-----------");

        var firstStudent = students.First();
        Console.WriteLine($" {firstStudent.Id} {firstStudent.Name}");
        Console.WriteLine("-----------");


        var lastStudent = students.Last();
        Console.WriteLine($" {lastStudent.Id} {lastStudent.Name}");
        Console.WriteLine("-----------");


        var taken = students.taken(2);
        foreach (var student in taken)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }
        Console.WriteLine("-----------");

        var selectedNames = students.SelectMethod(s => s.Name);
        Console.WriteLine("Selected Names:");
        foreach (var name in selectedNames)
        {
            Console.WriteLine(name);
        }

    }

}
