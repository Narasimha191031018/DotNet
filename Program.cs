using System;


namespace Accspecifiers
{
    public class Program
    {

        static void Main(string[] args)
        {

            //Company c = new Company(101,"Changepond");
            //c.displayCompanyDetails();

            Student s1 = new Student(1, "suha");
            Console.WriteLine(s1.sid);
            Console.WriteLine(Student.collegename);

        }
    }
}