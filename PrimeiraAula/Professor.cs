using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiraAula
{
    public class Professor : Pessoa
    {
        private string email;
        private string senha;
        private string titulacao;
        private double salario;
        private DateTime dataadmissao;
     

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Titulacao { get => titulacao; set => titulacao = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime Dataadmissao { get => dataadmissao; set => dataadmissao = value; }

       public override string GerarMatricula()
        {
            var matricula = Convert.ToInt64(DateTime.Now.ToString("yyyyMM")) * 15 + 2;
            return matricula.ToString();
        }
    }
}
