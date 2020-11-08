using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tvarkarastis
{
    public partial class Form1 : Form
    {
        SqlConn conn = new SqlConn();
        public Form1()
        {
            conn.connect();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.AddMonth();
        }
    }
}
