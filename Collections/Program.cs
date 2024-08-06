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

            //utilização do Array.IndexOf() = retorna o índice específicado.
            // * primeiro argumento é o array;
            // ** segundo arguento é o nome da variavel que irá puxar o índice...;
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));

            //utilização do Array.LastIndexOf() = retorna o índice específicado.
            // * primeiro argumento é o array;
            // ** segundo arguento é o nome da variavel que irá puxar o índice...;
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //utilização do Array.Reverse() = inverte os índices do array.
            // * recebe como argumento o array;
            Array.Reverse(aulas);
            Imprimir(aulas);

            //ao utilizar de novo, inverte novamente
            Array.Reverse(aulas);
            Imprimir(aulas);

            //utilização do Array.Resize() = redimensiona o tamanho do array
            // * primeiro argumento ref + array;
            // ** segundo argumento é o numero de índices;
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            //ao reutilizar, redimensiona o tamanho do array, porem os índices a mais estarão como null
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            //utilização do Array.Sort() = organiza o array em ordem alfabética
            Array.Sort(aulas);
            Imprimir(aulas);

            //criando novo array
            string[] copia = new string[2];

            //utilização do Array.Copy = faz uma cópia do array.
            // * primeiro argumento: array a ser copiado;
            // ** segundo argumento: índice do array a ser copiado;
            // *** terceiro argumento: array destino a ser gravado a cópia;
            // **** quarto argumento: índice do array destino;
            // ***** quinto argumento: tamanho do índice;
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            //utilização do método .Clone() = copia todo o conteúdo do array;
            //neste exemplo, o retorno desse método é do tipo Objeto, o `as string` está sendo usando para alterar a tipagem;
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            //utilização do método Array.Clear() = limpa os índices do array;
            // * primeiro argumento: especifica o array a ser acessado;
            // ** segundo argumento: índice inicial a ser limpado;
            // *** terceiro argumento: índice final a ser limpado;
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
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