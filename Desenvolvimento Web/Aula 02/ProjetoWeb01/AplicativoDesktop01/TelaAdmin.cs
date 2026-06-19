using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {


        private static readonly HttpClient clientHttp = new();
        private const string urlApidmin = "http://localhost:5034/api/ususarios/Admin";


        public TelaAdmin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
