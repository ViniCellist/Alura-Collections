namespace Models
{
    public class Aluno
    {
        public string nome;
        public int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }
    }
}
