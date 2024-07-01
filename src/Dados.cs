using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonStream.src
{
    public class Dados{

        public string Contrato { get; set; } = "";

        public string Nome { get; set; } = "";

        public string Cpf { get; set; } = "";

        public string Pessoa { get; set;} = "";

        public string Valor  { get; set; } = "";

        public int Plano  { get; set; } = 0;

        public string Vencimento  { get; set; } = "";

        public int DDD  { get; set; } = 0;

        public string NumeroTelefone  { get; set; } = "";

        public string ToString(){
            return $"{Contrato} : {Nome} : {Cpf} : {NumeroTelefone}";
        }

  

    }
}