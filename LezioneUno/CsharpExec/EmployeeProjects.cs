using System;

namespace CsharpExec
{
    public class Employee21
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Project[] empPro = new Project[3];

        private int pos = 0;

        public Employee21(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void AddProjToEmp(Project pro)
        {
            if (pos < 3)
            {
                empPro[pos] = pro;
                pos++;
            }
            else
            {
                Console.WriteLine("Unable to add and extra project");
            }
        }

        public void PrintProjs()
        {
            Console.WriteLine(this);

            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine("\t" + empPro[i]);
            }
        }

        public override string ToString()
        {
            return "id: " + Id + ", Name: " + Name + ", Age:" + Age;
        }

    }

    public class Project
    {
        public int Id { get; set; }
        public string Prjname { get; set; }
        public float Budget { get; set; }

        public Project(int id, string prjName, float budget)
        {
            Id = id;
            Prjname = prjName;
            Budget = budget;
        }

        public override string ToString()
        {
            return "Id:" + Id + ", Projecj name: " + Prjname + ", Budget: " + Budget;
        }

    }

    internal class EmployeeProjects
    {
        static void Main123(string[] args)
        {
            Employee21 e1 = new Employee21(1, "a", 23);
            e1.AddProjToEmp(new Project(1, "test1", 25.4f));
            e1.AddProjToEmp(new Project(2, "test2", 24.4f));
            e1.AddProjToEmp(new Project(3, "test3", 25.4f));
            e1.AddProjToEmp(new Project(4, "test4", 25.4f));

            e1.PrintProjs();
        }
    }
}
