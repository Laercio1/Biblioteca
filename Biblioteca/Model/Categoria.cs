namespace Model
{
    public class Categoria
    {
        private int codigo;
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
