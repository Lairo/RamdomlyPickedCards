namespace math
{
    class BigMath
    {
        static void Main()
        {
            int height = 179;
            int width = 83;
            int area = Multiply(height, width);

            int Multiply(int factorial1, int factorial2)
            {
                int product = factorial1 * factorial2;
                return product;
            }


            Console.WriteLine(area);
        }
    }
}

