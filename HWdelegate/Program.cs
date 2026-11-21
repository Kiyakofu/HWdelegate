namespace HWdelegate
{
    internal class Program
    {
        delegate void MessageDelegate(string text);

        static void PrintNormal(string msg)
        {
            Console.WriteLine("Normal: " + msg);
        }

        static void PrintUpper(string msg)
        {
            Console.WriteLine("UPPER: " + msg.ToUpper());
        }

        static void PrintWithStars(string msg)
        {
            Console.WriteLine("*** " + msg + " ***");
        }



        delegate int MathOperation(int a, int b);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }


        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static bool IsFibonacci(int n)
        {
            if (n < 0) return false;
            int a = 0;
            int b = 1;
            while (a < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return a == n;
        }



        static void Main()
        {
            MessageDelegate showMessage = PrintNormal;
            showMessage("Hello C#");

            showMessage = PrintUpper;
            showMessage("Hello C#");

            showMessage = PrintWithStars;
            showMessage("Hello C#");


            MathOperation op;

            op = Add;
            Console.WriteLine("Add: " + op.Invoke(10, 5));

            op = Subtract;
            Console.WriteLine("Subtract: " + op.Invoke(10, 5));

            op = Multiply;
            Console.WriteLine("Multiply: " + op.Invoke(10, 5));


            int number = 13;

            Predicate<int> check = IsEven;
            Console.WriteLine(number + " is even: " + check(number));

            check = IsOdd;
            Console.WriteLine(number + " is odd: " + check(number));

            check = IsPrime;
            Console.WriteLine(number + " is prime: " + check(number));

            check = IsFibonacci;
            Console.WriteLine(number + " is Fibonacci: " + check(number));
        }
    }
}
