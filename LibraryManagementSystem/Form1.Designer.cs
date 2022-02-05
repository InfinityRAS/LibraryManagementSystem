namespace LibraryManagementSystem
{
    partial class loadingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingWindow));
            this.product_name = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Loading = new System.Windows.Forms.Label();
            this.product_version = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // product_name
            // 
            this.product_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.Transparent;
            this.product_name.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.product_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.ForeColor = System.Drawing.SystemColors.Control;
            this.product_name.Location = new System.Drawing.Point(88, 165);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(519, 42);
            this.product_name.TabIndex = 0;
            this.product_name.Text = "Library Management System";
            // 
            // company_name
            // 
            this.company_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.company_name.AutoSize = true;
            this.company_name.BackColor = System.Drawing.Color.Transparent;
            this.company_name.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.company_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name.ForeColor = System.Drawing.SystemColors.Control;
            this.company_name.Location = new System.Drawing.Point(68, 360);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(243, 24);
            this.company_name.TabIndex = 1;
            this.company_name.Text = "Application Aryan Official";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.logo_circle;
            this.logo.ErrorImage = global::LibraryManagementSystem.Properties.Resources.logo_circle;
            this.logo.Image = global::LibraryManagementSystem.Properties.Resources.logo_circle;
            this.logo.InitialImage = global::LibraryManagementSystem.Properties.Resources.logo_circle;
            this.logo.Location = new System.Drawing.Point(12, 350);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 46);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // Loading
            // 
            this.Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Loading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.SystemColors.Control;
            this.Loading.Location = new System.Drawing.Point(565, 360);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(103, 24);
            this.Loading.TabIndex = 3;
            this.Loading.Text = "Loading...";
            this.Loading.Click += new System.EventHandler(this.label1_Click);
            // 
            // product_version
            // 
            this.product_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.product_version.AutoSize = true;
            this.product_version.BackColor = System.Drawing.Color.Transparent;
            this.product_version.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.product_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_version.ForeColor = System.Drawing.SystemColors.Control;
            this.product_version.Location = new System.Drawing.Point(565, 9);
            this.product_version.Name = "product_version";
            this.product_version.Size = new System.Drawing.Size(82, 24);
            this.product_version.TabIndex = 4;
            this.product_version.Text = "v2.2.5.0";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(-8, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(693, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.product_version);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.product_name);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loadingWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LibraryManagementSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label product_version;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

