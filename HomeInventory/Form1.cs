using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeInventory
{
    public partial class frmInventory : Form
    {
        SqlConnection inventoryConnection;
        SqlCommand inventoryCommand;
        SqlDataAdapter inventoryAdapter;
        DataTable inventoryTable;
        CurrencyManager inventoryManager;

        bool selectedFile = false;
        public frmInventory()
        {
            InitializeComponent();
        }
        // Page 686
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            try
            {
                // connect to sales database
                inventoryConnection = new SqlConnection(
                    "Server=(localdb)\\MSSQLLocalDB;" + 
                    "AttachDbFilename=" + Path.GetFullPath("SQLInventoryDB.mdf") + 
                    ";Integrated Security=True;" + 
                    "Connect Timeout=30;");
                inventoryConnection.Open();
                // establish inventory command object
                inventoryCommand = new SqlCommand(
                    "SELECT * " +
                    "FROM Inventory " +
                    "ORDER BY Item", inventoryConnection);
                // establish inventory data adapter/data table
                inventoryAdapter = new SqlDataAdapter();
                inventoryAdapter.SelectCommand = inventoryCommand;
                inventoryTable = new DataTable();
                inventoryAdapter.Fill(inventoryTable);
                // bind controls
                txtItem.DataBindings.Add("Text", inventoryTable, "Item");
                txtLocation.DataBindings.Add("Text", inventoryTable, "Location");
                txtStore.DataBindings.Add("Text", inventoryTable, "Store");
                dtpDatePurchased.DataBindings.Add("Text", inventoryTable, "DatePurchased");
                txtPurchaseCost.DataBindings.Add("Text", inventoryTable, "PurchaseCost");
                txtSerialNumber.DataBindings.Add("Text", inventoryTable, "SerialNumber");
                chkEngraved.DataBindings.Add("Checked", inventoryTable, "Engraved");
                lblPhotoFile.DataBindings.Add("Text", inventoryTable, "PhotoFile");
                // establish currency manager
                inventoryManager = (CurrencyManager)
                this.BindingContext[inventoryTable];
                selectedFile = true;
            }
            catch(Exception ex)
            {
                selectedFile = false;
                MessageBox.Show(
                    ex.Message,
                    "Error establishing database file connection.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedFile != false)
            {
                try
                {
                    // save the update Inventory table
                    SqlCommandBuilder inventoryAdapterCommands = new
                        SqlCommandBuilder(inventoryAdapter);
                    inventoryAdapter.Update(inventoryTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error Saving Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // close the connection
                inventoryConnection.Close();
                // dispose of the objects
                inventoryCommand.Dispose();
                inventoryAdapter.Dispose();
                inventoryTable.Dispose();
            }
        }
    }
}
