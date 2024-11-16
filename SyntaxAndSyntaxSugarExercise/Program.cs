using System.ComponentModel.Design;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 10;
            var reponse = answer < 9? $"{answer} is less than nine" : $"{answer} is greater than nine or equal to 9";
            Console.WriteLine(reponse);
            //if (answer < 9)
            //{
                //reponse = answer + "is less than nine";
                
            //}

            //{
              //  else 
            
        }
    }
}