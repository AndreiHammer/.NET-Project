using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Proiect; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        List<Inchiriere> listaInchirieri;
        Client c;

        public Form4(List<Inchiriere> listaInchirieri)
        {
            InitializeComponent();
            this.listaInchirieri = listaInchirieri;
        }

        private void btnAfiseazaClientiDB_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clienti", connection);
                adapter.Fill(dt);
                dgvClienti.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afișarea clienților: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void dgvClienti_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nume = (dgvClienti.Rows[e.RowIndex].Cells[0].Value.ToString());
            string adresa = (dgvClienti.Rows[e.RowIndex].Cells[1].Value.ToString());
            string telefon = (dgvClienti.Rows[e.RowIndex].Cells[2].Value.ToString());
            c = new Client(nume, adresa, telefon);
        }

        private void btnStergeClient_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM CLIENTI WHERE Numar_Telefon = @telefon", connection);
                command.Parameters.AddWithValue("@telefon", c.NumarTelefon);
                command.ExecuteNonQuery();
                MessageBox.Show("Clientul a fost sters");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergerea Clientului: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
