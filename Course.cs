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

    public void Enroll(string Student)
    {
        if (Student.Contains(Student))
        {
            System.Console.WriteLine($"{Student} är redan anmäld till kursen {Name}");
            return;
        }
        if (Students.Count >= MaxSeats)
        {
            System.Console.WriteLine($"Kursen är full. Sök igen nästa år!");
            return;
        }
        else
        {
            Students.Add(Student);
            System.Console.WriteLine($"{Student} änmäldes till {Name}");
        }
    }
}