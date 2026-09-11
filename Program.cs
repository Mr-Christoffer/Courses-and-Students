Console.WriteLine("Hello, World!");

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

System.Console.WriteLine(christoffer);