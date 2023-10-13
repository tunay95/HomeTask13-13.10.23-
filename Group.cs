using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13_13._10._23_
{
    internal class Group
    {

        private string _no;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (CheckNo(value))
                {
                    _no = value;
                }
            }
        }
        public int StudentLimit { get; set; }
        Student[] Students;
        public Group()
        {
            Students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public Student[] FilterByName(string look)
        {
            Student[] filterStudent = new Student[0];
            for (int i = 0; i < Students.Length; i++)
            {
                if ($"{Students[i].Name} {Students[i].Surname}".ToLower().Contains(look))
                {
                    Array.Resize(ref filterStudent, filterStudent.Length + 1);
                    filterStudent[filterStudent.Length - 1] = Students[i];
                }
            }
            return filterStudent;
        }


        public bool CheckNo(string no)
        {
            if (char.IsUpper(no[0]) && char.IsUpper(no[1]))
            {
                for (int i = 2; i < 5; i++)  //if (char.IsDigit(no[2]) && char.IsDigit(no[3])&&char.IsDigit(no[4])) { }
                {
                    if (!char.IsDigit(no[i]))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;

        }



    }
}

