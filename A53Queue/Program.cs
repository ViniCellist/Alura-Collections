﻿namespace A53Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento@");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}