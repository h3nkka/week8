using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Student
    {
        private string id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public string ID {
            get { return id; }
            set
            {
                if (!idList.Contains(value))
                {
                    id = value;
                    idList.Add(value);
                }
                else
                    Console.WriteLine("Error: ID already exists!");
            }
        }

        public static List<string> idList = new List<string>();

        public Student(string f, string l, string i, string g)
        {
            FirstName = f;
            LastName = l;
            ID = i;
            Group = g;
        }
    }
}
