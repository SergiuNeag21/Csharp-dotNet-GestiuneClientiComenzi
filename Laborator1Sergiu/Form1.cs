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

namespace Laborator1Sergiu
{
    public partial class Form1 : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DESKTOP-ICB55V9\\SQLEXPRESS;Initial Catalog=MagazinOnlineDB;" +
            "TrustServerCertificate=True;Integrated Security=True");
        SqlDataAdapter daClienti, daComenzi;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        BindingSource bsClienti, bsComenzi;
        private string connectionString = "Data Source=DESKTOP-ICB55V9\\SQLEXPRESS;Initial Catalog=MagazinOnlineDB;" +
            "TrustServerCertificate=True;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridComenzi.SelectedRows[0];
                int idComanda = Convert.ToInt32(selectedRow.Cells["IdComanda"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Ștergere din tabelul DetaliiComanda
                    string deleteDetaliiComandaQuery = "DELETE FROM DetaliiComanda WHERE IdComanda = @idComanda";
                    using (SqlCommand command = new SqlCommand(deleteDetaliiComandaQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idComanda", idComanda);
                        command.ExecuteNonQuery();
                    }

                    // Ștergere din tabelul Comenzi
                    string deleteComenziQuery = "DELETE FROM Comenzi WHERE IdComanda = @idComanda";
                    using (SqlCommand command = new SqlCommand(deleteComenziQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idComanda", idComanda);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                // datagridview cu datele actualizate
                dataGridComenzi.Rows.Remove(selectedRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare! " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                daComenzi.UpdateCommand = new SqlCommand("UPDATE Comenzi SET idComanda = @idComanda, idClient = @idClient, DataComanda = @DataComanda, TotalComanda = @TotalComanda WHERE idComanda = @idComanda", cs);
                daComenzi.UpdateCommand.Parameters.Add("@idComanda", SqlDbType.Int).Value = Int32.Parse(tbIdComanda.Text);
                daComenzi.UpdateCommand.Parameters.Add("@idClient", SqlDbType.Int).Value = Int32.Parse(tbIdClient.Text);
                daComenzi.UpdateCommand.Parameters.Add("@DataComanda", SqlDbType.Date).Value = tbDataComanda.Text;
                daComenzi.UpdateCommand.Parameters.Add("@TotalComanda", SqlDbType.Int).Value = Int32.Parse(tbTotalComanda.Text);

                cs.Open();
                daComenzi.UpdateCommand.ExecuteNonQuery();
                cs.Close();

                ds.Tables["Comenzi"].Clear();
                daComenzi.Fill(ds, "Comenzi");

                MessageBox.Show("Datele au fost actualizate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare! " + ex.Message) ;
            }
        }

        private void tbIdComanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDataComanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotalComanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                daComenzi.InsertCommand = new SqlCommand("Insert into Comenzi VALUES(@idComanda, @idClient, @DataComanda, @TotalComanda)", cs);
                daComenzi.InsertCommand.Parameters.Add("@idComanda", SqlDbType.Int).Value = Int32.Parse(tbIdComanda.Text);
                daComenzi.InsertCommand.Parameters.Add("@idClient", SqlDbType.Int).Value = Int32.Parse(tbIdClient.Text);
                daComenzi.InsertCommand.Parameters.Add("@DataComanda", SqlDbType.Date).Value = tbDataComanda.Text;
                daComenzi.InsertCommand.Parameters.Add("@TotalComanda", SqlDbType.Int).Value = Int32.Parse(tbTotalComanda.Text);

                cs.Open();
                daComenzi.InsertCommand.ExecuteNonQuery();
                cs.Close();

                ds.Tables["Comenzi"].Clear();
                daComenzi.Fill(ds, "Comenzi");

                MessageBox.Show("Datele au fost adaugate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare! " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
            daClienti = new SqlDataAdapter("select * from Clienti", cs);
            daComenzi = new SqlDataAdapter("select * from Comenzi", cs);
            cb = new SqlCommandBuilder(daClienti);

            daClienti.Fill(ds, "Clienti");
            daComenzi.Fill(ds, "Comenzi");

            DataRelation dr = new DataRelation("FK__Comenzi__IdClien__38996AB5",
            ds.Tables["Clienti"].Columns["idClient"], ds.Tables["Comenzi"].Columns["idCLient"]);
            ds.Relations.Add(dr);

            bsClienti = new BindingSource();
            bsComenzi = new BindingSource();

            bsClienti.DataSource = ds;
            bsClienti.DataMember = "Clienti";

            bsComenzi.DataSource = bsClienti;
            bsComenzi.DataMember = "FK__Comenzi__IdClien__38996AB5";

            dataGridClienti.DataSource = bsClienti;
            dataGridComenzi.DataSource = bsComenzi;
        }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare! " + ex.Message);
            }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
