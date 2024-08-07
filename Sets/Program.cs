namespace A31OPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sets = Conjuntos
            //1 - Não permite duplicidade
            //2 - Os elementos não tem ordem específica

            //declarando set de alunos

            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
        }
    }
}
