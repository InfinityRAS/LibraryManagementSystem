using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class loadingWindow : Form
    {
        public loadingWindow()
        {
            InitializeComponent();

            //this.FormClosed += LoadingWindow_FormClosed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LibraryManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);

            if (progressBar1.Value == 100)
            {
                this.Hide();
                timer1.Enabled = false;
                mainWindow mainWindow = new mainWindow();
                mainWindow.Show();
            }
        }
    }
}
