using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class student
    {
        public int year;
        public int id;
        public Dictionary<string, List<int>> subjects = new Dictionary<string, List<int>>();
        public string name;

        public void AddSubject (string subject)
        {
            subjects.Add(subject, new List<int>());
        }
        public void AddGrade (string subject, int grade)
        {
            if (subjects.ContainsKey(subject)) 
            {
                if(grade > 0 || grade < 6)
                {
                    subjects[subject].Add(grade);
                }
                else
                {
                    Console.WriteLine("Cannot do, the grade is not valid.");
                }
            }
            else
            {
                Console.WriteLine("Cannot do, the student does not have this subject.");
            }
        }
        public double CalculateSubjectGrade (string subject)
        {
            if (subjects.ContainsKey(subject))
            {
                double average = subjects[subject].Average();
                return average;
            }
            else
            {
                Console.WriteLine("Cannot do, the student does not have the subject.");
                return 0;
            }
        }
        public double CalculateTotalGrade (string subject)
        {
            if (subjects.ContainsKey(subject))
            {
                double final = subjects.Values.Average();
            }
            else
            {
                Console.WriteLine("Cannot do, the student does not have the subject.");
                return 0;
            }
        }
    }
}
