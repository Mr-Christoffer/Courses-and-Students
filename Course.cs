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
}