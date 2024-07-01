using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace JsonStream.src
{
    public class HistoriasRecovery
    {
        public string IdAcordo { get; set; }
        public string IdCliente { get; set; }
        public string IdCarteira { get; set; }
        public string Carteira { get; set; }
        public string DtmModAcordo { get; set; }
        public string EstadoAcordo { get; set; }
        public string DtmCadastroAcordo { get; set; }
        public string DtmCelebracaoAcordo { get; set; }
        public string VlrSOP { get; set; }

        public string VlrSAT { get; set; }

        public string VlrDesconto { get; set; }

        public string VlrAcordo { get; set; }
        public string FgPlanoAVista { get; set; }
                
        public string DtmPagamentoAvista { get; set; }

        public string VlrEntradaAcordo { get; set; }

        public string DtmPagamentoEntrada { get; set; }

        public string QtdParcelasTotal { get; set; }

        public string QtdParcelasPagas { get; set; }


        public string DtmUltimoPagamento { get; set; }                

        public string QtdParcelasPendentes { get; set; } 
        
        public string QtdParcelasVencidas { get; set; } 

        public string VlrTotalVencido { get; set; }

        public string CategoriaAcordo { get; set; }           

      public string ToString(){
            
            string mensagem = "";

            PropertyInfo[] properties = typeof(HistoriasRecovery).GetProperties();
            foreach (PropertyInfo property in properties){

                mensagem += $"{property.Name}:{property.GetValue(this)},";
                
            }
            return mensagem;
            // return $"{IdAcordo}-{IdCliente}-{IdCarteira}-{Carteira}-{DtmModAcordo}-{EstadoAcordo}";
        }
    }


}
