using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileDB
{
    public partial class FormDB : Form
    {

        SqlConnection sqlConexion = new SqlConnection();
        String sID = String.Empty;

        public FormDB()
        {
            InitializeComponent();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            try
            {
                String sConexion = String.Empty, sDB = @"C:\Ejemplo\Test.mdf";

                sConexion = String.Format(@"Data Source = .\SQLEXPRESS; AttachDbFilename = {0}; Integrated Security = True; Connect Timeout = 30; User Instance = True", sDB.Trim());

                sqlConexion.ConnectionString = sConexion;

                sqlConexion.Open();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT ID, String FROM ExampleTable (NOLOCK)", sqlConexion);

                DataTable dt = new DataTable();

                sqlAdapter.Fill(dt);

                gridExample.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlComando = new SqlCommand(String.Format("INSERT INTO ExampleTable (ID, String) VALUES ({0}, '{1}')", tbID.Text, tbString.Text), sqlConexion);

                sqlComando.ExecuteNonQuery();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT ID, String FROM ExampleTable (NOLOCK)", sqlConexion);

                DataTable dt = new DataTable();

                sqlAdapter.Fill(dt);

                gridExample.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridExample_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sID = gridExample.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (MessageBox.Show(this, String.Format("Eliminar: {0}", sID), "¿Borrar registro?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlCommand sqlComando = new SqlCommand(String.Format("DELETE FROM ExampleTable WHERE ID = {0}", sID), sqlConexion);

                    sqlComando.ExecuteNonQuery();

                    SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM ExampleTable (NOLOCK)", sqlConexion);

                    DataTable dt = new DataTable();

                    sqlAdapter.Fill(dt);

                    gridExample.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
