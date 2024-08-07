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

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }

        public override bool Equals(object? obj)
        {
            Aluno outro = obj as Aluno;

            if (obj == null) return false;

            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
