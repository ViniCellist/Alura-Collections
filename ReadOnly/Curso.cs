using A23ListasDeObjetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    internal class Curso
    {
		private IList<Aula> aulas;

		public IList<Aula> Aulas
		{
			get { return new ReadOnlyCollection<Aula>(aulas); }
		}

		private string nome;
		private string instutor;

        public Curso(string nome, string instutor)
        {
            this.nome = nome;
            this.instutor = instutor;
			this.aulas = new List<Aula>();
        }

        public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}


		public string Instrutor
		{
			get { return instutor; }
			set { instutor = value; }
		}

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }
    }
}
