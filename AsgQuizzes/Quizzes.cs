using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgQuizzes
{
    /// <summary>
    /// HINT: Implement this methods to make all tests in QuizzesTest.cs pass
    /// </summary>
    public class Quizzes
    {
        /// Expected time to resolve: 2 minutes
        public bool IsPalindrome(string str)
        {
            throw new NotImplementedException();
        }

        /// Expected time to resolve: 2 minutes
        public int[] GetOddNumbers(int n)
        {
            throw new NotImplementedException();
        }

        /// Expected time to resolve: 5 minutes
        public string[] OrderByAvgScoresDescending(IEnumerable<Exam> exams)
        {
            throw new NotImplementedException();
        }

        /// Expected time to resolve: 15 minutes
        public string GenerateBoard(string strInput)
        {
            throw new NotImplementedException();
        }

        /// Expected time to resolve: 60 minutes
        public int PostFixCalc(string s)
        {
            throw new NotImplementedException();
        }
    }

    public class Exam
    {
        public string Student { get; set; }
        public decimal Score { get; set; }

        public Exam(string student,decimal score)
        {
            this.Student = student;
            this.Score = score;
        }
    }

}
