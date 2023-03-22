namespace intro_to_OOP;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Georgin College");
        DateTime birthDateA = new DateTime (1989, 10, 03);
        //Instantiate student objects.
        Student studentA; // just a vairable and its empty at this point.
        studentA = new Student(100157573, "Tyler", "Johnson", "Computer Programming", birthDateA); // should break application
        studentA.average = 5000;
        Console.WriteLine($"{studentA.firstName}'s grade letter is {studentA.getLetterGrade()}");

        DateTime birthDateB = new DateTime(1990,01,01);
        Student studentB = new Student(1010101101, "jon", "snooooo", "arts", birthDateB);
        studentB.average = 78;
        Console.WriteLine($"{studentB.firstName}'s grade letter is {studentB.getLetterGrade()}");
    
    }
}
