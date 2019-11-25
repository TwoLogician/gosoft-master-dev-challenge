using System;

namespace master_dev_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = SquareOfDistance(5, 4, 10, 12);
            var result201 = ModifyArray(new[] { -20, 14, 11, -2, 3, -6, 42 });
            var result202 = ModifyArray(null);
            var result301 = CylinderOrSphere(5, 8);
            var result302 = CylinderOrSphere(4, 4);
            Console.WriteLine($"Result1: {result1}");
            Console.WriteLine();
            Console.WriteLine("Result2.1:");
            Array.ForEach(result201, x =>
            {
                Console.WriteLine(x);
            });
            Console.WriteLine($"Result2.2: {result202}");
            Console.WriteLine();
            Console.WriteLine($"Result3.1: {result301}");
            Console.WriteLine($"Result3.2: {result302}");
        }

        static int SquareOfDistance(int x1, int y1, int x2, int y2)
        {
            var x = x2 - x1;
            var y = y2 - y1;
            return Convert.ToInt32(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        static int[] ModifyArray(int[] arr)
        {
            if (arr == null) return null;
            var n = arr.Length;
            return Array.ConvertAll(arr, x =>
            {
                var i = Array.IndexOf(arr, x);
                return x >= 0 ? x * (n - i) : x * (n + i);
            });
        }

        static int CylinderOrSphere(int radius, int height)
        {
            return Convert.ToInt32(radius == height ? 4 * Math.Pow(radius, 3) : 3 * Math.Pow(radius, 2) * height);
        }
    }
}
