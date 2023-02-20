namespace DictionaryAndForeachTITpe22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tänavad = new Dictionary<int, string>()
            {
                {1, "Turu tänav" },
                {2, "Pikk tänav" },
                {3, "Kespäeva tänav" }
            };
            foreach (var street in tänavad)
            {
                Console.WriteLine($"{street.Key} - {street.Value}");
            }
        }
    }
}