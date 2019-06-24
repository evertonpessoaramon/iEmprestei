using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Amigo
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Emprestimo> EmprestimosRealizados { get; set; }
    }
}