class Course
{
    public string Name = "";
    public int MaxSeats;
    public List<string> Students = new List<string>();

    // Contructor - runs automatically when we write new Course
    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Contains(student.Name))
        {
            System.Console.WriteLine($"{student.Name} är redan anmäld till kursen {Name}");
            return;
        }
        if (Students.Count >= MaxSeats)
        {
            System.Console.WriteLine($"Kursen är full. Sök igen nästa år!");
            return;
        }


        Students.Add(student.Name);
        student.Courses.Add(Name);
        System.Console.WriteLine($"{student.Name} änmäldes till {Name}");
    }

    public void Remove(Student student)
    {
        if (Students.Contains(student.Name))
        {
            Students.Remove(student.Name);
            student.Courses.Remove(Name);
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
        System.Console.WriteLine($"Följande elever är inskrivna i kursen {Name}");
        foreach (var n in Students)
        {
            Console.WriteLine(n);
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }

}