using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Illustrate assemblies.
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            // add "f" to tell the compiler to treat as floating point number.
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            //GradeBook book2 = new GradeBook();
            //GradeBook book2 = book;
            //book2.AddGrade(75);


        }
    }
}
