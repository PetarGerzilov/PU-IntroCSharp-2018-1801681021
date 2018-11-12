using System;

namespace SmileysForStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = System.IO.File.ReadAllLines(@"C:\Users\PESHO\Desktop\STD2018-1b-PetarGerzilov-1801681021\Students.txt");
            int studentSum = 0;
            int smiley = '☻';
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in student)
            {
                student = line.Split(' ');
                string firstName = student[1];
                string fathersName = student[2];
                string lastName = student[3];
                string fullName = $"{firstName} {fathersName} {lastName}";

                for (int i = 0; i < fullName.Length; i++)
                {
                    studentSum = studentSum + (int)fullName[i];
                }
                if (studentSum > 15000)
                    Console.WriteLine($" {fullName} {(char)smiley} => {studentSum}");
            }
        }
    }
}
