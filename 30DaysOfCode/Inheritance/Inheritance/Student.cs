using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        private int[] testScores;


        // Write your constructor here
        public Student() { }
        public Student(string firstName, string lastName, int identification, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here

        public char Calculate()
        {
            int total = 0;
            int average = 0;
            char grade;
            for (int i = 0; i < testScores.Length; i++)
            {
                total += testScores[i];
            }

            average = total / testScores.Length;
            if ((average >= 90) && (average <= 100))
            {
                grade = 'O';
            }
            else if (average >= 80 && average < 90)
            {
                grade = 'E';
            }
            else if (average >= 70 && average < 80)
            {
                grade = 'A';
            }
            else if (average >= 55 && average < 70)
            {
                grade = 'P';
            }
            else if (average >= 40 && average < 55)
            {
                grade = 'D';
            }
            else
            {
                grade = 'T';
            }
            return grade;
        }


    }
}
