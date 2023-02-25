using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoedas
{
    public class MoedaCorrente
    {
        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal Compra { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal Venda { get; set;}

        [JsonProperty(PropertyName = "variation")]
        public decimal Variacao { get; set; }


    }
}
