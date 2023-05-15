using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;

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
            Root example = null;
            string json = "";
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://www.nif.pt/");
                json = await client.GetStringAsync($"?json=1&q={Inserir_NIF.Text}&key={key}");
                json = json.Replace($"{Inserir_NIF.Text}\":", "NIF\":");
                example = JsonSerializer.Deserialize<Root>(json);
                int NIF_Cliente = example.Records.NIF.Nif;
                Inserir_NIF.Text = NIF_Cliente.ToString();
                string Nome_Cliente = example.Records.NIF.Title;
                Inserir_Nome.Text = Nome_Cliente.ToString();
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
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (example != null)
            {

            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                Inserir_Imagem_URL.Text = openFileDialog1.FileName;
            }
            if (Inserir_NIF.Text == "504213660")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\Diogo Major Vieira\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tgn.png";
            }
            else if (Inserir_NIF.Text == "504783661")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\Diogo Major Vieira\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\sas.png";
            }
            else if (Inserir_NIF.Text == "509442013")
            {
                Inserir_Imagem_URL.Text = @"C:\Users\Diogo Major Vieira\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\nex.png";
            }
            else
            {
                Inserir_Imagem_URL.Text = @"C:\Users\Diogo Major Vieira\Desktop\Curso Profissional\12º ano\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tcm.png";
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
            }
        }
    }
}