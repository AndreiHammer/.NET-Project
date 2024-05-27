using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class Form1 : Form
    {
        List<Film> listaFilmeDisponibile = new List<Film>();
        Inchiriere instanta;
        List<Inchiriere> listaInchirieri = new List<Inchiriere>();
        SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Proiect; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
            tbTelefon.KeyPress += new KeyPressEventHandler(tbTelefon_KeyPress);
        }

        private void btnPopulareLbCasete_Click(object sender, EventArgs e)
        {
            lbCasete.Items.Clear();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Casete.xml");

            XmlNodeList xnList = xmlDocument.SelectNodes("/lista");
            foreach (XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach (XmlNode node in xmlNodeList)
                {
                    string titlu = node["titlu"].InnerText;
                    string gen = node["gen"].InnerText;
                    int anLansare = Convert.ToInt32(node["anLansare"].InnerText);
                    float pret = float.Parse(node["pret"].InnerText);
                    Film film = new Film(titlu, gen, anLansare, pret);
                    lbCasete.Items.Add(film.AfisareDetalii());
                    listaFilmeDisponibile.Add(film);
                }
            }
        }

        private void lbCasete_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            string film = (string)lbCasete.Items[e.Index];

            e.DrawBackground();

            using (Brush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(film.ToString(), e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lbCasete_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pentru asistenta in folosirea aplicatiei contactati autorul pe mail: andreiciocan04@gmail.com",
                "Ajutor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );
        }
        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dataCurenta = DateTime.Now.ToString("dd MMMM yyyy");
            MessageBox.Show(
                "Aceasta aplicatie serveste drept proiect final la materia Programarea Aplicatiilor Windows.\n\n" +
                "Autor: Andrei Ciocan\n" +
                "Versiune: 1.0\n" +
                "Data: "  + dataCurenta + "\n\n" +
                 "Aceasta aplicatie permite gestionarea inchirierii de casete video prin intermediul unei interfete grafice " +
                "user-friendly. Utilizatorii pot adauga, edita si sterge informatii despre clienti si filme. Datele sunt " +
                "salvate intr-un fisier XML si intr-o baza de date SQL pentru persistenta datelor.\n\n" +
                "Functionalitati principale:\n" +
                " - Popularea listei de filme disponibile dintr-un fisier XML.\n" +
                " - Inregistrarea inchirierilor cu detalii despre clienti si filmele inchiriate.\n" +
                " - Validarea datelor de intrare, cum ar fi numele, adresa si numarul de telefon.\n" +
                " - Calcularea si afisarea costului total al inchirierilor.\n" +
                " - Salvarea si restaurarea inchirierilor din fisiere text.\n" +
                " - Afisarea graficelor si a situatiei inchirierilor.\n" +
                " - Vizualizarea bazei de date a clientilor.\n\n" ,
                "Despre Aplicatie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbCasete.Items.Clear();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Casete.xml");

            XmlNodeList xnList = xmlDocument.SelectNodes("/lista");
            foreach (XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach (XmlNode node in xmlNodeList)
                {
                    string titlu = node["titlu"].InnerText;
                    string gen = node["gen"].InnerText;
                    int anLansare = Convert.ToInt32(node["anLansare"].InnerText);
                    float pret = float.Parse(node["pret"].InnerText);
                    Film film = new Film(titlu, gen, anLansare, pret);
                    lbCasete.Items.Add(film.AfisareDetalii());
                    listaFilmeDisponibile.Add(film);
                }
            }
        }

        private void btnInregistrareInchiriere_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.Equals(tbNume.Text.Trim(), string.Empty))
            {
                errorProvider1.SetError(tbNume, "Introduceti nume!");
            }
            else if (string.Equals(tbAdresa.Text.Trim(), string.Empty))
            {
                errorProvider1.SetError(tbAdresa, "Introduceti adresa!");
            }
            else if (tbTelefon.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(tbTelefon, "Introduceti numarul de telefon!");
            }
            else
            {
                string nume = tbNume.Text;
                string adresa = tbAdresa.Text;
                string numarTelefon = tbTelefon.Text;
                try
                {
                    if (lbCasete.SelectedItems.Count == 0)
                    {
                        throw new Exception("Selectați cel puțin un film pentru închiriere.");
                    }


                instanta = new Inchiriere();
                Client c = new Client(nume, adresa, numarTelefon);
                instanta.Client = c;

                instanta.Filme.Clear();
                float total = 0;
                foreach (var selectedItem in lbCasete.SelectedItems)
                {
                    string filmDetails = selectedItem.ToString();
                    foreach (Film film in listaFilmeDisponibile)
                    {
                        if (film.AfisareDetalii() == filmDetails)
                        {
                            instanta = instanta + film;
                            total += film.Pret;
                            break;
                        }
                    }
                }
                instanta.TotalPlata = total;

                tbInchirieri.AppendText(Environment.NewLine + instanta.ToString());

                listaInchirieri.Add(instanta);

                InsertToDatabase(instanta);

                tbNume.Clear();
                tbAdresa.Clear();
                tbTelefon.Clear();

                lbCasete.ClearSelected();
                tbCosInchirieri.Clear();
                tbNume.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void InsertToDatabase(Inchiriere i)
        {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Clienti(Nume,Adresa,Numar_Telefon) VALUES (@nume, @adresa, @nrTelefon)", connection);
                    command.Parameters.AddWithValue("@nume", i.Client.NumeClient);
                    command.Parameters.AddWithValue("@adresa", i.Client.Adresa);
                    command.Parameters.AddWithValue("@nrTelefon", i.Client.NumarTelefon);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Eroare la inserarea clientului: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
        }

        private void tbTelefon_TextChanged(object sender, EventArgs e)
        {
            if (tbTelefon.Text.Length != 10)
            {
                errorProvider1.SetError(tbTelefon, "Numărul de telefon trebuie să aibă exact 10 cifre.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void lbCasete_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nrFilme = lbCasete.SelectedItems.Count;
            float total = 0;
            foreach(var selectedItem in lbCasete.SelectedItems)
            {
                string filmDetails = selectedItem.ToString();
                foreach (Film film in listaFilmeDisponibile)
                {
                    if (film.AfisareDetalii() == filmDetails)
                    {
                        total += film.Pret;
                        break;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numar de casete inchiriate: " + nrFilme);
            sb.AppendLine("Total de plata: " + total + " lei");
            tbCosInchirieri.Text = sb.ToString();
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Inchiriere i in listaInchirieri)
                {
                    sw.WriteLine(i.ToString());
                }
                sw.Close();
                MessageBox.Show($"S-a salvat fisierul : ${saveFileDialog1.FileName}");
                tbInchirieri.Clear();
            }
        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbInchirieri.Text += sr.ReadToEnd();
                sr.Close();
            }
        }

        private void afisareGraficSituatieInchirieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaInchirieri);
            form2.Show();
        }

        private void afisareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(listaInchirieri); 
            form3.Show();
        }

        private void afisareBazaDeDateClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(listaInchirieri);
            form4.Show();
        }
    }
}
