namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declared and initialized variables
            
            string classSort = "Hufflepuff";

            int studentBody = 15000;

            char house = 'H';

            bool ofAge = true;
            
            decimal spellsCast = 150.15m;
            
            string welcome = "Welcome to Hogwarts!  Please provide us with your name:";

            double gradeAverage = 85.50;
            
            //Generated welcome message
            
            Console.WriteLine(welcome);
            
            string studentName = Console.ReadLine();
            
            Console.WriteLine($"Perfect!  Glad to have you with us, {studentName}.  We will get you sorted into your class shortly.");
            
            Console.WriteLine($"During you time here, you will be expected to maintain a gradepoint average of {gradeAverage} in each of your classrooms.");
            
        }
    }
}
