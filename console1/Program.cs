
internal class Program
{
    private static void Main(string[] args)
    {
        {
            sbyte x = Convert.ToSByte(Console.ReadLine());
            sbyte x2 = Convert.ToSByte(Console.ReadLine());
            int y = Convert.ToInt32(Math.Max(x, x2));
            Console.WriteLine(Math.Abs(y));

            sbyte z = Convert.ToSByte(Console.ReadLine());
            sbyte z1 = Convert.ToSByte(Console.ReadLine());
            int c = Convert.ToInt32(Math.Min(z, z1));
            Console.WriteLine(Math.Abs(c));

            sbyte k = Convert.ToSByte(Console.ReadLine());
            int e = Convert.ToInt32(Math.Sqrt(k));
            Console.WriteLine(Math.Abs(e));

            double t = Convert.ToDouble(Console.ReadLine());
            int d = Convert.ToInt32(Math.Truncate(t));
            Console.WriteLine(d);

        }
    }
}