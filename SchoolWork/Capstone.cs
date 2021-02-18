using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork
{
    class Capstone : IPrintable
    {

        public DateTime CertificationDate { get; set; }
        public int Attempts { get; set; }
        public int Score { get; set; }

        public void Print() 
        {
            // can create a variable to make more complex console.writelines a bit easier to call
            var msg = $" CAPSTONE: Score: {Score}, on attempt {Attempts} - {CertificationDate}";
            Console.WriteLine(msg);
        }

        public int GetScore()
        {
            return Score;
        }
    }
}
