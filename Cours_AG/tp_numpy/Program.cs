namespace tp_numpy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listN1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.Write("La liste de base : ");

            foreach (int i in listN1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            List<int> listN2 = Numpy.Function(listN1, x => x * x);

            Console.Write("La liste modifiée : ");

            foreach (int i in listN2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
