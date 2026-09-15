class Student
{
    public string Name = "";
    public List<Course> CoursesList = new List<Course>();

    // Contructor
    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        Console.Clear();
        if (CoursesList.Contains(course))
        {
            System.Console.WriteLine($"{Name} är redan anmäld till kursen {course.Name}");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta...");
            Console.ReadKey();
            return;
        }
        if (course.StudentsList.Count >= course.MaxSeats)
        {
            System.Console.WriteLine($"{course.Name} är full. Sök igen nästa år!");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta...");
            Console.ReadKey();
            return;

        }

        course.StudentsList.Add(this);
        CoursesList.Add(course);

        System.Console.WriteLine($"{Name} anmäldes till {course.Name}");
    }

    public void Leave(Course course)
    {
        if (!CoursesList.Contains(course))
        {
            System.Console.WriteLine($"{Name} finns inte inskriven i kursen {course.Name} och kan därför inte skrivas ut.");
            return;

        }
        course.StudentsList.Remove(this);
        CoursesList.Remove(course);
        System.Console.WriteLine($"{Name} har nu skrivits ut från kursen {course.Name}");


    }

    public void Schedule()
    {
        // Console.Clear();
        if (CoursesList.Count == 0)
        {
            System.Console.WriteLine($"{Name} är inte inskriven i någon kurs.");
        }
        else
        {
            System.Console.WriteLine($"{Name} är inskriven i följande kurser:");
            for (int i = 0; i < CoursesList.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {CoursesList[i]}");
            }
        }

    }

    public override string ToString()
    {
        return Name;
    }



}