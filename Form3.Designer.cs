namespace SUPERMARKET
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            comboBox1 = new ComboBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            login = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.LightSeaGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Seller" });
            comboBox1.Location = new Point(206, 304);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Select Role";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtusername.ForeColor = Color.Black;
            txtusername.Location = new Point(206, 372);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter your name";
            txtusername.Size = new Size(179, 28);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(206, 423);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Enter your password";
            txtpassword.Size = new Size(179, 28);
            txtpassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(538, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.DeepSkyBlue;
            login.Location = new Point(317, 496);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(162, 496);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 606);
            Controls.Add(button2);
            Controls.Add(login);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login form";
            Load += Loginform_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtusername;
        private TextBox txtpassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button login;
        private Button button2;
    }
}