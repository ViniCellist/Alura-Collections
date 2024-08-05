
namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //definindo variveis tipo string
            string aulaIntro = "instrodução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //definindo array do tipo string com 3 índices, e definindo suas respectivas posições
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //mostrando no console o conteúdo salvo dentro do array
            Console.WriteLine(aulas);

            //chamada do método
            Imprimir(aulas);

            //mostrando o índice[0]
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            //nesse exemplo a variável continuará mostrando o primeiro conteúdo, pois era o que já estava salvo previamente
            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            //utilização do Array.IndexOf() - primeiro argumento é o array, segundo arguento é o nome da variavel que irá puxar o índice...
            //retorna o índice..
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas,aulaModelando));

            //utilização do Array.LastIndexOf() - primeiro argumento é o array, segundo arguento é o nome da variavel que irá puxar o índice...
            //retorna o índice
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //utilização do Array.Reverse() - recebe como argumento o array
            //inverte a ordem dos índices
            Array.Reverse(aulas);
            Imprimir(aulas);

            //ao utilizar de novo, inverte novamente
            Array.Reverse(aulas);
            Imprimir(aulas);

            //utilização do Array.Resize() - primeiro argumento ref + array, segundo argumento é o numero de índices
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            //ao reutilizar, redimensiona o tamanho do array, porem os índices a mais estarão como null
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}