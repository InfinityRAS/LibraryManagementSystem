using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void mainWindow_FormClosing(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void mainWindow_closed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
