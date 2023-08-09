namespace OperatorExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int a= 17;
            int b = 4;
            int quotient = a/b;
            var remainder = a % b;
            
          
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine( "What is the radius of your circle:" );

            var userInput = Console.ReadLine();
            
            var radius = double.Parse(userInput);

            Console.WriteLine(AreaofCircle(radius));
        }

        public static double AreaofCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }
}
