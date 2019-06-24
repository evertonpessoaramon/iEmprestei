using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
        public List<Amigo> Amigos { get; set; }
        public List<Objeto> Objetos { get; set; }
        public List<Emprestimo> ObjetosEmprestados { get; set;}
    }
}