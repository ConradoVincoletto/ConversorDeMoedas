using Newtonsoft.Json;

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
