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

            int[] values = new[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;

            foreach (int v in result)
                Console.Write($"{v} ");
            Console.ReadLine();
        }
    }
}

