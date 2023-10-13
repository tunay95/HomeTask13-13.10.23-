namespace HomeTask13_13._10._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Group List
            Group[] groups = new Group[0];

            //1. Create Group
            Console.WriteLine("Group Name: ");
            string GroupName = Console.ReadLine();
            Console.WriteLine("Student Limit: ");
            int Limit = int.Parse(Console.ReadLine());
            Group group = new Group(GroupName, Limit);

            Console.WriteLine("Group2 Name: ");
            string GroupName2 = Console.ReadLine();
            Console.WriteLine("Student Limit: ");
            int Limit2 = int.Parse(Console.ReadLine());
            Group group2 = new Group(GroupName2, Limit2);

            //Add groups to groups[] array
            Array.Resize(ref groups, groups.Length+2);
            groups[groups.Length-1] = group;
            groups[groups.Length-2] = group2;

            //2. Show All Groups
            foreach (Group EachGroup in groups)
            {
                Console.WriteLine(EachGroup.GroupInfo());
            }

            //3. Add Student
            string GroupNameAdd = Console.ReadLine();
            Student student = new Student()
            {
                Name = "Tunay",
                Surname = "Huseynli",
                AvgPoint = 100
            };
            foreach (Group EachGroup in groups)
            {
                if(EachGroup.No == GroupNameAdd)
                {
                    EachGroup.AddStudent(student);
                }
            }

            //Student student = new Student()
            //{
            //    Name = "Tunay",
            //    Surname = "Huseynli",
            //    AvgPoint = 95
            //};

            //Student student2 = new Student()
            //{
            //    Name = "Ilkin",
            //    Surname = "Recebov",
            //    AvgPoint = 95
            //};

            //Student student3 = new Student()
            //{
            //    Name = "Miraga",
            //    Surname = "Aliyev",
            //    AvgPoint = 92
            //};

            //Student student4 = new Student()
            //{
            //    Name = "Rufet",
            //    Surname = "Guliyev",
            //    AvgPoint = 94
            //};
            //Group group = new Group()
            //{
            //    No = "BB205",
            //    StudentLimit = 7
            //};
            //group.AddStudent(student);
            //group.AddStudent(student2);
            //group.AddStudent(student3);
            //group.AddStudent(student4);


            //foreach (var item in group.FilterByName("li"))
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}
            //int option;
            //do
            //{
            //    Console.WriteLine("1. For Create Group");
            //    Console.WriteLine("2. For Show all students");
            //    Console.WriteLine("3. For Add Student");
            //    Console.WriteLine("2. For filter by name");
            //    Console.WriteLine("0. Exit");
            //    Console.WriteLine("-----------");

            //    Console.WriteLine("Enter option:");

            //    int option = int.Parse(Console.ReadLine());

            //    switch (option)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter Group Name: ");
            //            string Group1 = Console.ReadLine();


            //            break;
            //        case 2:

            //            break;
            //        case 3:
            //            group.AddStudent(student);
            //            break;
            //        case 0:
            //            Console.WriteLine("Program was ended... Bye :)");
            //            break;
            //        default:
            //            Console.WriteLine("No such option!");
            //            break;
            //    }

            //} while (true);
        }
    }
   }




