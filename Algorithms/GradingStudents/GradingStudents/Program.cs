using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfStudents = 4;
            int[] grades = new int[] { 84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2, 29, 53, 61, 40, 14, 4, 29, 98, 37, 23, 46, 9, 79, 62, 20, 38, 51, 99, 59, 47, 4, 86, 61, 68, 17, 45, 6, 1, 95, 95 };

            int[] result = gradingStudents(grades);
            foreach(int i in result)
            {
                Console.WriteLine("FinalGrades: " + i);
            }
        }

        static int[] gradingStudents(int[] grades)
        {

            //Write your code here.
            List<int> gradeArr = new List<int>();
            int[] newArr = new int[] { };
            int finalGrade = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                int multipleOfFive = grades[i] % 5;
                Console.WriteLine("MOD 5: " + multipleOfFive);
                // Console.WriteLine("Remainder: " + (grades[i] + 2));
                if (grades[i] < 38)
                {
                    finalGrade = grades[i];
                    //Console.WriteLine("Grade < 38: " + finalGrade);
                }

                else
                {

                    if (multipleOfFive < 3)
                    {
                        finalGrade = grades[i];
                        //Console.WriteLine("Final grade: " + finalGrade);
                    }
                    else
                    {
                        finalGrade = grades[i] + 2;
                        //Console.WriteLine("Final grade: " + finalGrade);
                    }
                }
                gradeArr.Add(finalGrade);               
            }
            newArr = gradeArr.ToArray();
            return newArr;

        }
    }
}