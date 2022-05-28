namespace Model
{
    public class Usuario
    {
        private int codigo;
        private int tipoUsuario;
        private string nome;
        private string endereco;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string cpf;
        private string rg;
        private string telefone;
        private string email;
        private string dataCadastro;
        private string dataNascimento;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }







    }
}
