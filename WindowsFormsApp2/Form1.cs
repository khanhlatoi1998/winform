using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TPDBVUI\SQLEXPRESS;Initial Catalog=Oder;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        { 
            command = connection.CreateCommand(); // connect
            command.CommandText = "select * from oder";
            adapter.SelectCommand = command; // enforcement query
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void changeCode(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void infoWeight_Click(object sender, EventArgs e)
        {

        }

        private void infoWeight1_Click(object sender, EventArgs e)
        {

        }

        private void infoLong_Click(object sender, EventArgs e)
        {

        }

        private void infoLong1_Click(object sender, EventArgs e)
        {

        }

        private void infoWidth_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            inputCode.Text = dgv.Rows[i].Cells[0].Value.ToString();
            inputSenderName.Text = dgv.Rows[i].Cells[1].Value.ToString();
            inputSenderAddress.Text = dgv.Rows[i].Cells[2].Value.ToString();
            inputRecipientAddress.Text = dgv.Rows[i].Cells[3].Value.ToString();
            inputOrderWeight.Text = dgv.Rows[i].Cells[4].Value.ToString();
            inputOrderLong.Text = dgv.Rows[i].Cells[5].Value.ToString();
            inputOrderWidth.Text = dgv.Rows[i].Cells[6].Value.ToString();
            inputOderHeight.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "insert into oder values('" + inputCode.Text + "', '" + inputSenderName.Text + "', '" + inputSenderAddress.Text + "', '" + inputRecipientAddress.Text + "', '" + inputOrderWeight.Text + "', '" + inputOrderWeight.Text + "', '" + inputOrderWidth.Text + "', '" + inputOderHeight.Text + "')";
            //command.ExecuteNonQuery();
            //loadData();
        }

        private void btnFIxClick(object sender, EventArgs e)
        {

        }

        private void btnDeleteClick(object sender, EventArgs e)
        {

        }

        private void btnCreateClick(object sender, EventArgs e)
        {

        }
    }
}
