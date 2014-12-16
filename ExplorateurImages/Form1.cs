using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Objects;

namespace ExplorateurImages
{
    public partial class Form1 : Form
    {
        const String cnxStr = "metadata=res://*/Context.csdl|res://*/Context.ssdl|res://*/Context.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source={0};Initial Catalog={1};Integrated Security=True\"";
        Entities _context = null;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clic sur le bouton "Connexion"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCnx_Click(object sender, EventArgs e)
        {
            cbBdd.Properties.Items.Clear();
            cbBdd.Enabled = false;
            btLoad.Enabled = false;

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (var cnx = new SqlConnection(String.Format("Data Source={0}; Integrated Security=True;", txtServer.Text)))
                {
                    cnx.Open();

                    var databases = cnx.GetSchema("Databases");
                    foreach (DataRow database in databases.Rows)
                        cbBdd.Properties.Items.Add(database.Field<String>("database_name"));

                    cbBdd.Properties.Items.Remove("master");
                    cbBdd.Properties.Items.Remove("model");
                    cbBdd.Properties.Items.Remove("msdb");
                    cbBdd.Properties.Items.Remove("tempdb");
                }

                cbBdd.Enabled = true;
                btLoad.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }


        }

        /// <summary>
        /// Clic sur le bouton "Charger"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLoad_Click(object sender, EventArgs e)
        {
            _context = new Entities(String.Format(cnxStr, txtServer.Text, cbBdd.Text));
            gridControl1.DataSource = _context.SysBasisImage.Where(sbi => sbi.InFile == 0);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }


    }
}
