class Student
{
    public string Name = "";
    public List<string> Courses = new List<string>();

    // Contructor
    public Student (string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        if (Courses.Contains(course.Name))
        {
            System.Console.WriteLine($"{Name} är redan anmäld till kursen {course.Name}");
            return;
        }
        if (course.Students.Count >= course.MaxSeats)
        {
            System.Console.WriteLine($"{course.Name} är full.");
        }

        course.Students.Add(Name);
        Courses.Add(Name);

        System.Console.WriteLine($"{Name} anmäldes till {course.Name}");
    }



}