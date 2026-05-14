using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1_NIF_Form
{
    public partial class Form1 : Form
    {
        private readonly string key = "7081912941ec5e7715a8de32ef8213d7";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Gravar_Dados_JSON_Click(object sender, EventArgs e)
        {
            string json = null;
            Root example = null;

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://www.nif.pt/");
                json = await client.GetStringAsync($"?json=1&q={Inserir_NIF.Text}&key={key}");
                json = json.Replace($"{Inserir_NIF.Text}\":", "NIF\":");
                example = JsonConvert.DeserializeObject<Root>(json);
                int NIF = example.Records.NIF.Nif;
                Inserir_NIF.Text = NIF.ToString();
                string Nome = example.Records.NIF.Title;
                Inserir_Nome.Text = Nome.ToString();
                string Adereço = example.Records.NIF.Address;
                Inserir_Adereço.Text = Adereço.ToString();
                string PC4 = example.Records.NIF.Place.Pc4;
                Inserir_PC4.Text = PC4.ToString();
                string PC3 = example.Records.NIF.Place.Pc3;
                Inserir_PC3.Text = PC3.ToString();
                string Distrito = example.Records.NIF.Geo.Region;
                Inserir_Distrito.Text = Distrito.ToString();
                string Concelho = example.Records.NIF.Geo.County;
                Inserir_Concelho.Text = Concelho.ToString();
                string Freguesia = example.Records.NIF.Geo.Parish;
                Inserir_Freguesia.Text = Freguesia.ToString();
                string Email = example.Records.NIF.Contacts.Email;
                Inserir_Email.Text = Email.ToString();
                string Telefone = example.Records.NIF.Contacts.Phone;
                Inserir_Telefone.Text = Telefone.ToString();
                string Website = example.Records.NIF.Contacts.Website;
                Inserir_Website.Text = Website.ToString();
                string Fax = example.Records.NIF.Contacts.Fax;
                Inserir_Fax.Text = Fax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro de ligação com API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (example != null)
            {

            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                Inserir_Imagem_URL.Text = ofd.FileName;
            }
            if (Inserir_NIF.Text == "504213660")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\diogo\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tgn.png";
            }
            else if (Inserir_NIF.Text == "504783661")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\diogo\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\sas.png";
            }
            else if (Inserir_NIF.Text == "509442013")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\diogo\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\nex.png";
            }
            else if (Inserir_NIF.Text == "503646172")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\diogo\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tcm.png";
            }
            else if (Inserir_NIF.Text == "506971244")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\diogo\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\ipl.png";
            }
            else
            {
                MessageBox.Show($"O campo {Inserir_Imagem_URL.Text} não é válido para o NIF indicado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gravar_Dados_Entity_Click(object sender, EventArgs e)
        {
            using (NIFDBEntities ndbe = new NIFDBEntities())
            {
                NIF_Empresa n_e = new NIF_Empresa();
                {
                    n_e.NIF = int.Parse(Inserir_NIF.Text);
                    n_e.Name = Inserir_Nome.Text;
                    n_e.Address = Inserir_Adereço.Text;
                    n_e.PC4 = int.Parse(Inserir_PC4.Text);
                    n_e.PC3 = int.Parse(Inserir_PC3.Text);
                    n_e.Region = Inserir_Distrito.Text;
                    n_e.County = Inserir_Concelho.Text;
                    n_e.Parish = Inserir_Freguesia.Text;
                    n_e.Email = Inserir_Email.Text;
                    n_e.Phone = int.Parse(Inserir_Telefone.Text);
                    n_e.Website = Inserir_Website.Text;
                    n_e.Fax = int.Parse(Inserir_Fax.Text);
                    n_e.Imagem_URL = Inserir_Imagem_URL.Text;
                }
                ndbe.SaveChanges();
            }
        }
    }
}