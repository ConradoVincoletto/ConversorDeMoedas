using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoedas
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void FrmCotacaoDolar_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=733fd8ea";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(strURL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        MercadoFinanceiro mf = JsonConvert.DeserializeObject<MercadoFinanceiro>(result);
                        LblMst_Compra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mf.Moeda.Compra);
                        LblMst_Venda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mf.Moeda.Venda);
                        LblMst_Variacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mf.Moeda.Variacao / 100);
                    }
                    else
                    {
                        LblMst_Compra.Text = " _ ";
                        LblMst_Venda.Text = " _ ";
                        LblMst_Variacao.Text = " _ ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
