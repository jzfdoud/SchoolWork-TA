using System;

namespace SchoolWork
{
    class Program
    {
        static void Main(string[] args)
        {

            var jadaCapstone = new Capstone
            {
                Attempts = 1,
                CertificationDate = new DateTime(2020, 08, 15),
                Score = 100
            };

            var jadaGit = new Assessment
            {
                Topic = "Git/GitHub",
                DateOfAssessment = new DateTime(2020, 06, 15),
                Score = 120
            };

            var jadaSQL = new Assessment
            {
                Topic = "SQL",
                DateOfAssessment = new DateTime(2020, 07, 05),
                Score = 110
            };

            var jada = new IPrintable[]
            {
                jadaCapstone, jadaGit, jadaSQL
            };

            foreach(var item in jada)
            {
                item.Print();
            }
        }
    }
}
