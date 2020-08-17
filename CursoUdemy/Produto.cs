using System.Globalization;

namespace CursoUdemy
{
    class Produto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Produto(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}