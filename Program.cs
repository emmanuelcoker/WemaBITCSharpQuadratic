namespace WemaBITCSharpQuadratic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //solve quadratic
            //get values of A

            //loop
            char doYouWantToContinue = 'Y';
            do
            {

                Console.WriteLine("------- Welcome To Quadratic Solver ------");
                StartQuadratic();

                Console.WriteLine();
                Console.WriteLine("Do you want to run again Y or N");
                doYouWantToContinue = CheckContinue(Convert.ToChar(Console.ReadLine()));
        
            } while (doYouWantToContinue == 'Y');

        }

        public static char CheckContinue(char Val)
        {

            if (Val == 'y' ||  Val == 'Y')
            {
                return 'Y';
            }

       
            return 'N';

        }

        public static void StartQuadratic()
        {
            var quadraticEquation = new Quadratic();
            // Input for Side A
            double A;
            do
            {
                Console.Write("Enter the Value for A: ");
            } while (!double.TryParse(Console.ReadLine(), out A));

            //Input value for B
            double B;
            do
            {
                Console.Write("Enter the Value for B: ");
            } while (!double.TryParse(Console.ReadLine(), out B));

            //Input value for C
            double C;
            do
            {
                Console.Write("Enter the Value for C: ");
            } while (!double.TryParse(Console.ReadLine(), out C));


            quadraticEquation.A = A;
            quadraticEquation.B = B;
            quadraticEquation.C = C;
            quadraticEquation.SolveQuadratic();
        }


        public class Quadratic
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }
            public double Discriminant {  get; set; }
            public double Solution1 { get; set; }
            public double Solution2 { get; set; }


            public void SolveQuadratic()
            {
                var d = B * B - (4 * A * C);

                if(d < 0)
                {
                    Console.WriteLine("This Quadratic equation does not have a solution!");
                    return;
                }

                Solution1 = (-B - Discriminant) / (2 * A);
                Solution2 = (-B + Discriminant) / (2 * A);

                Console.WriteLine($"The Answers for the Quadratic Equation: {A}x^2 +{B}x + {C} is :" +
                $" x1 = {Solution1} and x2 = {Solution2}");

            }
        }
    }
}