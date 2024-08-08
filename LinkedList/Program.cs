namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate",
                "banana",
                "caqui",
                "damasco",
                "figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }


            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");
            Console.WriteLine("d4.Value" + d4.Value);

            var d2 = dias.AddBefore(d4, "segunda");
        }
    }
}