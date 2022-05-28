using System;

namespace Model
{
    public class HistoricoUsuario
    {
        private int tombo;
        private int codigoUsuario;
        private int codigoFuncionario;
        private DateTime dataLocacao;
        private DateTime dataDevolucao;
        private int exemplar;
        private DateTime dataRenovacao;

        public DateTime Datarenovacao
        {
            get { return dataRenovacao; }
            set { dataRenovacao = value; }
        }

        public int Exemplar
        {
            get { return exemplar; }
            set { exemplar = value; }
        }

        public DateTime DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }

        public DateTime DataLocacao
        {
            get { return dataLocacao; }
            set { dataLocacao = value; }
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
