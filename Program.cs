List<Course> allCourses = new List<Course>();
List<Student> allStudents = new List<Student>();
MainMenu();
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
        System.Console.WriteLine("2. Lista för att sedan välja kurs");
        System.Console.WriteLine("0. Gå tillbaka till huvudmeny");
        char choice2 = Console.ReadKey().KeyChar;
        System.Console.WriteLine("");
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
                Console.Clear();
                for (int i = 0; i < allCourses.Count; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {allCourses[i]}");
                }
                string? chosenCourse = Console.ReadLine();
                if (int.TryParse(chosenCourse, out int chosenNumber))
                {
                    if ((chosenNumber - 1) <= allCourses.Count && chosenNumber > 0)
                    {
                        SpecificCourseMenu(allCourses[chosenNumber - 1]);
                    }
                }
                break;
            case '0':
                courseMenuRunning = false;
                break;


        }
    }

}
void SpecificCourseMenu(Course chosenCourse)
{
    bool specificCourseMenuRunning = true;
    while (specificCourseMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine($"MENY FÖR KURSEN: {chosenCourse}");
        chosenCourse.RollCall();
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine("1. Skriv in elev i kursen");
        System.Console.WriteLine("2. Ta bort en elev från kursen");
        System.Console.WriteLine("0. Gå tillbaka till KURSMENY");
        char choice5 = Console.ReadKey().KeyChar;
        System.Console.WriteLine("");
        switch (choice5)
        {
            case '1':
                Console.Clear();
                System.Console.WriteLine("Välj elev att skriva in i kursen " + chosenCourse + " genom att skriva elevens nummer och tryck på enter");
                for (int i = 0; i < allStudents.Count; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {allStudents[i]}");
                }

                string? input = Console.ReadLine();
                if (int.TryParse(input, out int chosenNumber))
                {
                    if ((chosenNumber - 1) <= allStudents.Count && chosenNumber > 0)
                    {
                        Student chosenStudent = allStudents[chosenNumber - 1]; //Translates to student
                        chosenCourse.Enroll(chosenStudent);
                    }
                }
                break;
            case '2':
                Console.Clear();
                chosenCourse.RollCall();
                System.Console.WriteLine("Välj elev att ta bort från kursen " + chosenCourse + " genom att skriva elevens nummer och tryck på enter");
                string? input2 = Console.ReadLine();
                if (int.TryParse(input2, out int chosenNumber2))
                {
                    if ((chosenNumber2 - 1) <= chosenCourse.StudentsList.Count && chosenNumber2 > 0)
                    {
                        chosenCourse.Remove(chosenCourse.StudentsList[chosenNumber2 - 1]);
                    }
                }
                break;
            case '0':
                specificCourseMenuRunning = false;
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
                for (int i = 0; i < allStudents.Count; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {allStudents[i]}");
                }
                string? chosenStudent = Console.ReadLine();
                if (int.TryParse(chosenStudent, out int chosenNumber))
                {
                    if (chosenNumber <= allStudents.Count && chosenNumber > 0)
                    {
                        SpecificStudentMenu(allStudents[chosenNumber - 1]);
                    }
                }
                break;
            case '0':
                studentMenuRunning = false;
                break;
        }
    }

}
void SpecificStudentMenu(Student chosenStudent)
{
    bool specificStudentMenuRunning = true;
    while (specificStudentMenuRunning)
    {
        Console.Clear();
        System.Console.WriteLine($"MENY FÖR STUDENTEN: {chosenStudent}");
        chosenStudent.Schedule();
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine($"1. Skriv in {chosenStudent} i kurs");
        System.Console.WriteLine($"2. Ta bort {chosenStudent} från kurs");
        System.Console.WriteLine("0. Gå tillbaka till STUDENTMENY");
        char choice5 = Console.ReadKey().KeyChar;
        switch (choice5)
        {
            case '1':
                Console.Clear();
                System.Console.WriteLine($"Välj kurs att skriva in {chosenStudent} i genom att skriva kursens nummer och tryck enter:");
                for (int i = 0; i < allCourses.Count; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {allCourses[i]}");
                }

                string? input = Console.ReadLine();
                if (int.TryParse(input, out int chosenNumber))
                {
                    if ((chosenNumber - 1) <= allCourses.Count && chosenNumber > 0)
                    {
                        Course chosenCourse = allCourses[chosenNumber - 1]; //Translates to course
                        chosenStudent.Join(chosenCourse);
                    }
                }
                break;
            case '2':
                Console.Clear();
                chosenStudent.Schedule();
                System.Console.WriteLine($"Välj kurs att ta bort {chosenStudent} från genom att skriva kursens nummer och tryck enter:");
                string? input2 = Console.ReadLine();
                if (int.TryParse(input2, out int chosenNumber3))
                {
                    if ((chosenNumber3 -1) <= chosenStudent.CoursesList.Count && chosenNumber3 > 0)
                    {
                        chosenStudent.Leave(chosenStudent.CoursesList[chosenNumber3-1]);
                    }
                }
                break;
            case '0':
                specificStudentMenuRunning = false;
                break;
        }
    }
}


