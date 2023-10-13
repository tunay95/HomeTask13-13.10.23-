namespace HomeTask13_13._10._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Tunay",
                Surname = "Huseynli",
                AvgPoint = 95
            };

            Student student2 = new Student()
            {
                Name = "Ilkin",
                Surname = "Recebov",
                AvgPoint = 95
            };

            Student student3 = new Student()
            {
                Name = "Miraga",
                Surname = "Aliyev",
                AvgPoint = 92
            };

            Student student4 = new Student()
            {
                Name = "Rufet",
                Surname = "Guliyev",
                AvgPoint = 94
            };
            Group group = new Group()
            {
                No = "BB205",
                StudentLimit = 7
            };
            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);


            foreach (var item in group.FilterByName("li"))
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            int option;
            do
            {
                Console.WriteLine("1. For Create Group");
                Console.WriteLine("2. For Show all students");
                Console.WriteLine("3. For Add Student");
                Console.WriteLine("2. For filter by name");
                Console.WriteLine("0. Exit");
                Console.WriteLine("-----------");

                Console.WriteLine("Enter option:");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Enter option:.");
                }

                switch (option)
                {
                    case 1:
                        
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        group.AddStudent(student);
                        break;
                    case 0:
                        Console.WriteLine("Program was ended... Bye :)");
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);
        }
    }
   }




