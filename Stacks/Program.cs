﻿


namespace A52Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
        }

        internal class Navegador
        {
            private readonly Stack<string> historicoAnterior = new Stack<string>();
            private readonly Stack<string> historicoProximo = new Stack<string>();

            private string atual = "vazia";

            public Navegador()
            {
                Console.WriteLine("Página atual " + atual);
            }

            internal void Anterior()
            {
                if (historicoAnterior.Any())
                {
                    historicoProximo.Push(atual);
                    atual = historicoAnterior.Pop();
                    Console.WriteLine("Página atual " + atual);
                }
            }

            internal void NavegarPara(string url)
            {
                historicoAnterior.Push(url);
                atual = url;
                Console.WriteLine("Página atual " + atual);
            }

            internal void Proximo()
            {
                if (historicoProximo.Any())
                {
                   atual = historicoProximo.Pop();
                   Console.WriteLine("Página atual " + atual);
                }
            }
        }
    }
}