/*Console.WriteLine("Hello, World!");

Course csharp = new Course("C#", 2);
Student christoffer = new Student("Christoffer Nilsson");
Student anna = new Student("Anna Pihl");
Student mahmud = new Student("Mahmud Al-Karim");
Course hacking = new Course("Hacking", 1);

csharp.Enroll(christoffer);
csharp.Enroll(anna);
csharp.Enroll(mahmud);
csharp.Remove(anna);

Console.WriteLine(string.Join(", ", csharp.Students)); // -> Anna
Console.WriteLine(string.Join(", ", anna.Courses));    // -> C#
csharp.Enroll(christoffer);
csharp.Enroll(mahmud);
csharp.RollCall();
System.Console.WriteLine(csharp);
christoffer.Join(csharp);
christoffer.Join(hacking);
christoffer.Leave(hacking);
anna.Leave(hacking);
mahmud.Join(hacking);
hacking.RollCall();
christoffer.Join(hacking);
christoffer.Join(csharp);
christoffer.Schedule();

System.Console.WriteLine(christoffer); */
using System.Security.Cryptography.X509Certificates;

bool programRunning = true;
List<Course> allCourses = new List<Course>();
while (programRunning)
{
    Console.Clear();
    System.Console.WriteLine("Välkommen till NBI/Handelsakademins nya datasystem");
    System.Console.WriteLine("MENY");
    System.Console.WriteLine("1. Kurser");
    System.Console.WriteLine("2. Studenter");
    System.Console.WriteLine("0. Avsluta");
    char choice = Console.ReadKey().KeyChar;
    if (choice == '1')
    {
        Kurser();
    }
    if (choice == '2')
    {

    }
    if (choice == '0')
    {
        programRunning = false;
        continue;
    }
}

void Kurser()
{
    Console.Clear();
    System.Console.WriteLine("KURSMENY");
    System.Console.WriteLine("1. Lägg till ny kurs");
    System.Console.WriteLine("2. Ta bort en kurs");
    System.Console.WriteLine("3. Lista för att sedan välja kurs");
    System.Console.WriteLine("0. Gå tillbaka till huvudmeny");
    char choice2 = Console.ReadKey().KeyChar;
    if (choice2 == '1')
    {
        System.Console.WriteLine("Skriv namnet på den nya kursen: ");
        string? newCourse = Console.ReadLine();
        System.Console.WriteLine("Ange antal platser: ");
        string? newMax = Console.ReadLine();
        if (int.TryParse(newMax, out int newmax))
        {
            Course course = new Course(newCourse, newmax);
            allCourses.Add(course);
        }
    }
    if (choice2 == '2')
    {

    }
    if (choice2 == '3')
    {
        foreach (var c in allCourses)
        {
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    if (choice2 == '0')
    {
        return;
    }
}



