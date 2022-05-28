using System;

namespace Model
{
    public class Emprestimo
    {
        private int tombo;
        private int codigoUsuario;
        private int codigoFuncionario;
        private DateTime dataEmprestimo;
        private DateTime dataPrevista;
        private int exemplar;

        public int Exemplar
        {
            get { return exemplar; }
            set { exemplar = value; }
        }

        public DateTime DataPrevista
        {
            get { return dataPrevista; }
            set { dataPrevista = value; }
        }

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }

        public int CodigoFuncionario
        {
            get { return codigoFuncionario; }
            set { codigoFuncionario = value; }
        }

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

    }
}
