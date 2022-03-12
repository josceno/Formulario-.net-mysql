using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySql.Data;



namespace form_2._1_cadastro_conta
{
    public partial class Form1 : Form
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User id=root;database= final_db; password=aRROMBADOSdOcARALHO654718!@");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'final_dbDataSet2.tabelah'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelahTableAdapter1.Fill(this.final_dbDataSet2.tabelah);
            // TODO: esta linha de código carrega dados na tabela 'final_dbDataSet.tabelah'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelahTableAdapter.Fill(this.final_dbDataSet.tabelah);
            // combox data insert
            cbmestado.Items.Add("SE");
            cbmestado.Items.Add("RE");
            cbmestado.Items.Add("SP");
            cbmestado.Items.Add("RJ");
            cbmestado.Items.Add("BH");
            cbmestado.Items.Add("RR");
            cbmestado.Items.Add("RO");

            cbmsexo.Items.Add("M");
            cbmsexo.Items.Add("F");








        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                connection.Open();
                MySqlCommand command = new MySqlCommand("insert into tabelaH(cd_codid, nm_Nome, em_email, cid_cidade, es_estado, se_sexo) values(null, ?, ?, ?, ?, ?)", connection);
                command.Parameters.Add("@nm_Nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                command.Parameters.Add("@em_email", MySqlDbType.VarChar, 60).Value = txtemail.Text;
                command.Parameters.Add("@cid_cidade", MySqlDbType.VarChar, 30).Value = txtcidade.Text;               
                command.Parameters.Add("@es_estado", MySqlDbType.VarChar, 2).Value = cbmestado.SelectedItem.ToString();
                command.Parameters.Add("@sexo", MySqlDbType.VarChar, 2).Value = cbmsexo.SelectedItem.ToString();
                command.ExecuteNonQuery();

                
                var sqlQuery = "SELECT * FROM tabelaH";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                {
                    using(DataTable data = new DataTable()) 
                    {
                        adapter.Fill(data);
                        tabelahDataGridView.DataSource = data;
                    }
                } 
                

                
                MessageBox.Show(txtNome,"inserido");
                connection.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("falha ao conectar"+ erro);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbmestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("delete from tabelaH where cd_codid = ?", connection);
            command.Parameters.Clear();
            command.Parameters.Add("@cd_dados", MySqlDbType.Int32).Value = txtcodid.Text;

            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            MessageBox.Show("removido");
            connection.Close();

           string sqlQuery = "SELECT * FROM tabelaH";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                using (DataTable data = new DataTable())
                {
                    adapter.Fill(data);
                    tabelahDataGridView.DataSource = data;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select nm_nome, cd_codid, em_email, cid_cidade, es_estado, se_sexo from tabelaH where cd_codid = ?",connection);
                command.Parameters.Clear();
                command.Parameters.Add("@cd_codid", MySqlDbType.Int32).Value = txtcodid.Text;
                command.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();

                txtNome.Text = dr.GetString(0);
                txtemail.Text = dr.GetString(2);
                txtcidade.Text = dr.GetString(3);
                cbmestado.Text = dr.GetString(4);
                cbmsexo.Text = dr.GetString(5);


                connection.Close();

                string sqlQuery0 = ("SELECT cd_codid, nm_nome, em_email, cid_cidade, es_estado, se_sexo FROM tabelah where cd_codid = ");
                string sqlQuery = sqlQuery0 + txtcodid.Text;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                {

                    using (DataTable data = new DataTable())
                    {
                        adapter.Fill(data);
                        tabelahDataGridView.DataSource = data;
                    }
                }
            }       
            catch(Exception erro)
            {
                MessageBox.Show("falhou" + erro);
            }
        }

       
        private void tabelahDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var item = tabelahDataGridView.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(item.ToString());
            txtcodid.Text = item.ToString();

            connection.Open();
            MySqlCommand command = new MySqlCommand("select nm_nome, cd_codid, em_email, cid_cidade, es_estado, se_sexo from tabelaH where cd_codid = ?", connection);
            command.Parameters.Clear();
            command.Parameters.Add("@cd_codid", MySqlDbType.Int32).Value = txtcodid.Text;
            command.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = command.ExecuteReader();
            dr.Read();

            txtNome.Text = dr.GetString(0);
            txtemail.Text = dr.GetString(2);
            txtcidade.Text = dr.GetString(3);
            cbmestado.Text = dr.GetString(4);
            cbmsexo.Text = dr.GetString(5);
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("update tabelah set nm_nome = ?, em_email = ? where cd_codid = ?", connection);
            command.Parameters.Add("@nm_Nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
            command.Parameters.Add("@em_email", MySqlDbType.VarChar, 60).Value = txtemail.Text;
            
            command.Parameters.Add("@cd_codid", MySqlDbType.Int32).Value = txtcodid.Text;
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
            string sqlQuery = "SELECT * FROM tabelaH";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                using (DataTable data = new DataTable())
                {
                    adapter.Fill(data);
                    tabelahDataGridView.DataSource = data;
                }
            }
        }
    }

}
