using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Masa","Niemi","A1111","TTV17S4");
            Student student2 = new Student("Allan", "Aalto", "B2222", "TTV17S3");
            Student student3 = new Student("Hanna", "Husso", "C3333", "TTV17S2");
            Student student4 = new Student("Teppo", "Testaaja", "D4444", "TTV17S1");
            List<Student> studentlist = new List<Student>() { student1, student2, student3, student4 };
            foreach (Student s in studentlist)
            {
                Console.WriteLine("{0} {1} {2} {3}", s.FirstName, s.LastName, s.ID, s.Group);
            }

            Console.WriteLine("Input data for new students. Input nothing to break.");
            
            while (true)
            {
                Console.WriteLine("\nFirst name:");
                string fn = Console.ReadLine();
                    if (fn == "")
                    break;
                Console.WriteLine("Last name:");
                string ln = Console.ReadLine();
                    if (ln == "")
                    break;
                Console.WriteLine("ID (note: has to be unique):");
                string id = Console.ReadLine();
                    if (id == "")
                        break;
                    if (Student.idList.Contains(id))
                    {
                        Console.WriteLine("ID already exists!");
                        continue;
                    }
                Console.WriteLine("Group:");
                string gr = Console.ReadLine();
                if (gr == "")
                    break;
                new Student(fn, ln, id, gr);
                Console.WriteLine("New student created!");
            }

            Console.ReadKey(true);
        }
    }
}
