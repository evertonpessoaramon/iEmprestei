using System;

namespace Dominio.Entidades
{
    public class Emprestimo
    {
        public DateTime DataEmpretimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool EmprestimoFinalizado { get; set; }
        public Objeto Objeto { get; set; }
    }
}