class Course
{
    public string Name = "";
    public int MaxSeats;

    public List<Student> StudentsList = new List<Student>(); // Saves students in a list as objects not as string.

    // Contructor - runs automatically when we write new Course
    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        Console.Clear();
        if (StudentsList.Contains(student))
        {
            System.Console.WriteLine($"{student.Name} är redan anmäld till kursen {Name}");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta...");
            Console.ReadKey();
            return;
        }
        if (StudentsList.Count >= MaxSeats)
        {
            System.Console.WriteLine($"Kursen är full. Sök igen nästa år!");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta...");
            Console.ReadKey();
            return;
        }


        StudentsList.Add(student);
        student.CoursesList.Add(this);
        System.Console.WriteLine($"{student.Name} änmäldes till {Name}");
    }

    public void Remove(Student student)
    {
        if (StudentsList.Contains(student))
        {
            StudentsList.Remove(student);
            student.CoursesList.Remove(this);
            System.Console.WriteLine($"{student.Name} har nu tagits bort från kursen {Name}");
        }
        else
        {
            System.Console.WriteLine($"{student.Name} finns inte inskriven på kursen {Name}");
            return;
        }
    }

    public void RollCall()
    {
        // Console.Clear();
        if (StudentsList.Count == 0)
        {
            System.Console.WriteLine($"Inga elever är inskrivna i kursen {Name}");
        }
        else
        {
            System.Console.WriteLine($"Följande elever är inskrivna i kursen {Name}");
            for (int i = 0; i < StudentsList.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {StudentsList[i]}");
            }
        }

        
    }
   
    public override string ToString()
    {
        return $"{Name} ({StudentsList.Count}/{MaxSeats} platser)";
    }



}