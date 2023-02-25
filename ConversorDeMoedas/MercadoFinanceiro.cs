using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoedas
{
    public class MercadoFinanceiro
    {
        public MercadoFinanceiro()
        {
            this.Moeda = new MoedaCorrente();
        }

        [JsonProperty(PropertyName = "currencies")]
        public MoedaCorrente Moeda { get; set; }
    }
}
