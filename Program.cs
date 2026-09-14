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
List<Student> allStudents = new List<Student>();
MainMenu();
/*while (programRunning)
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
}*/




void MainMenu()
{
    bool mainMenuRunning = true;
    while (mainMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine("Välkommen till NBI/Handelsakademins nya datasystem");
        System.Console.WriteLine("MENY");
        System.Console.WriteLine("1. Kurser");
        System.Console.WriteLine("2. Studenter");
        System.Console.WriteLine("0. Avsluta");
        char choice = Console.ReadKey().KeyChar;
        switch (choice)
        {
            case '1':
                Console.Clear();
                CourseMenu();       // går ner i en undermeny
                break;
            case '2':
                StudentMenu();
                break;
            case '0':
                mainMenuRunning = false;
                break;

        }

    }
}
void CourseMenu()
{
    bool courseMenuRunning = true;
    while (courseMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine("KURSMENY");
        System.Console.WriteLine("1. Lägg till ny kurs");
        System.Console.WriteLine("2. Ta bort en kurs");
        System.Console.WriteLine("3. Lista för att sedan välja kurs");
        System.Console.WriteLine("0. Gå tillbaka till huvudmeny");
        char choice2 = Console.ReadKey().KeyChar;
        switch (choice2)
        {
            case '1':
                Console.Clear();
                System.Console.WriteLine("Skriv namnet på den nya kursen: ");
                string? newCourse = Console.ReadLine();
                System.Console.WriteLine("Ange antal platser: ");
                string? newMax = Console.ReadLine();
                if (int.TryParse(newMax, out int newmax))
                {
                    Course course = new Course(newCourse, newmax);
                    allCourses.Add(course);
                }
                break;
            case '2':
                break;
            case '3':
                Console.Clear();
                foreach (var c in allCourses)
                {
                    Console.WriteLine(c);
                    Console.ReadLine();
                }
                break;
            case '0':
                courseMenuRunning = false;
                break;


        }
    }

}


void StudentMenu()
{
    bool studentMenuRunning = true;
    while (studentMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine("STUDENTMENY");
        System.Console.WriteLine("1. Lägg till ny elev");
        System.Console.WriteLine("2. Lista för att sedan välja elev");
        System.Console.WriteLine("0. Gå tillbaka till huvudmeny");
        char choice3 = Console.ReadKey().KeyChar;
        switch (choice3)
        {
            case '1':
                Console.Clear();
                System.Console.WriteLine("Skriv namnet på den nya eleven: ");
                string? newStudent = Console.ReadLine();
                Student student = new Student(newStudent);
                allStudents.Add(student);
                break;
            case '2':
                Console.Clear();
                /*foreach (var s in allStudents)
                {
                    Console.WriteLine(s);
                }*/
                for (int i = 0; i < allStudents.Count; i++)
                {
                    System.Console.WriteLine($"{i+1}. {allStudents[i]}");
                }
                string? chosenStudent = Console.ReadLine();
                if (int.TryParse(chosenStudent, out int chosenNumber))
                {
                    if(chosenNumber <= allStudents.Count && chosenNumber > 0)
                    {
                        SpecificStudentMenu(allStudents[chosenNumber - 1]);
                    }
                }
                break;
        }
    }

}
void SpecificStudentMenu (Student chosenStudent)
{
    bool specificStudentMenuRunning = true;
    while (specificStudentMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine("MENY FÖR ELEVEN: " + chosenStudent);
        System.Console.WriteLine("1. Lägg till ny elev");
        System.Console.WriteLine("2. Lista för att sedan välja elev");
        System.Console.WriteLine("0. Gå tillbaka till huvudmeny");
        Console.ReadLine();
    }
}
