Console.WriteLine("Hello, World!");

Course csharp = new Course("C#", 2);
Student christoffer = new Student("Christoffer Nilsson");
Student anna = new Student("Anna Pihl");
Student mahmud = new Student("Mahmud Al-Karim");

csharp.Enroll(christoffer);
csharp.Enroll(anna);
csharp.Enroll(mahmud);

Console.WriteLine(string.Join(", ", csharp.Students)); // -> Anna
Console.WriteLine(string.Join(", ", anna.Courses));    // -> C#