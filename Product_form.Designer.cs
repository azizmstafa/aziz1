namespace SUPERMARKET
{
    partial class Product_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_form));
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            Productsdgv = new DataGridView();
            btnAdd = new Button();
            btnUpgrade = new Button();
            btnDelete = new Button();
            txtProductQuantity = new TextBox();
            txtProductName = new TextBox();
            btnCategories = new Button();
            btnSellers = new Button();
            txtProductID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSelling = new Button();
            panel1 = new Panel();
            button9 = new Button();
            cbSearchCategory = new ComboBox();
            cbSelectionCategory = new ComboBox();
            label8 = new Label();
            txtProductPrice = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Productsdgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1048, -156);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 10);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkGoldenrod;
            button3.Location = new Point(-222, 713);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(10, 10);
            button3.TabIndex = 13;
            button3.Text = "Log out";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkGoldenrod;
            button2.Location = new Point(-216, 99);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(10, 10);
            button2.TabIndex = 14;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGoldenrod;
            button1.Location = new Point(-216, 27);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 12;
            button1.Text = "Sellers";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkGoldenrod;
            button4.Location = new Point(-216, 172);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(10, 10);
            button4.TabIndex = 15;
            button4.Text = "Selling";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(139, -156);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 32);
            label1.TabIndex = 10;
            label1.Text = "Supermarket Mangment System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1288, -72);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DarkGoldenrod;
            button5.Location = new Point(18, 797);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(118, 44);
            button5.TabIndex = 20;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            // 
            // Productsdgv
            // 
            Productsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Productsdgv.Location = new Point(429, 124);
            Productsdgv.Margin = new Padding(4);
            Productsdgv.Name = "Productsdgv";
            Productsdgv.RowHeadersWidth = 51;
            Productsdgv.Size = new Size(749, 447);
            Productsdgv.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkGoldenrod;
            btnAdd.Location = new Point(300, 527);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpgrade
            // 
            btnUpgrade.BackColor = Color.Transparent;
            btnUpgrade.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpgrade.ForeColor = Color.DarkGoldenrod;
            btnUpgrade.Location = new Point(164, 527);
            btnUpgrade.Margin = new Padding(4);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(118, 44);
            btnUpgrade.TabIndex = 6;
            btnUpgrade.Text = "Upgarde";
            btnUpgrade.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DarkGoldenrod;
            btnDelete.Location = new Point(24, 527);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 44);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(205, 270);
            txtProductQuantity.Margin = new Padding(4);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(196, 31);
            txtProductQuantity.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(205, 196);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(196, 31);
            txtProductName.TabIndex = 5;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Transparent;
            btnCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.DarkGoldenrod;
            btnCategories.Location = new Point(13, 183);
            btnCategories.Margin = new Padding(4);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(129, 44);
            btnCategories.TabIndex = 21;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnSellers
            // 
            btnSellers.BackColor = Color.Transparent;
            btnSellers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellers.ForeColor = Color.DarkGoldenrod;
            btnSellers.Location = new Point(24, 111);
            btnSellers.Margin = new Padding(4);
            btnSellers.Name = "btnSellers";
            btnSellers.Size = new Size(118, 44);
            btnSellers.TabIndex = 19;
            btnSellers.Text = "Sellers";
            btnSellers.UseVisualStyleBackColor = false;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(205, 130);
            txtProductID.Margin = new Padding(4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(196, 31);
            txtProductID.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(40, 196);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 3;
            label5.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(40, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 32);
            label3.TabIndex = 1;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(262, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(362, 47);
            label2.TabIndex = 0;
            label2.Text = "Manage Products";
            label2.Click += label2_Click;
            // 
            // btnSelling
            // 
            btnSelling.BackColor = Color.Transparent;
            btnSelling.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelling.ForeColor = Color.DarkGoldenrod;
            btnSelling.Location = new Point(24, 256);
            btnSelling.Margin = new Padding(4);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(118, 44);
            btnSelling.TabIndex = 22;
            btnSelling.Text = "Selling";
            btnSelling.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(cbSearchCategory);
            panel1.Controls.Add(cbSelectionCategory);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtProductPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Productsdgv);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpgrade);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtProductQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(154, 5);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 750);
            panel1.TabIndex = 18;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.DarkGoldenrod;
            button9.Location = new Point(950, 81);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(118, 35);
            button9.TabIndex = 16;
            button9.Text = "Refresh";
            button9.UseVisualStyleBackColor = false;
            // 
            // cbSearchCategory
            // 
            cbSearchCategory.BackColor = Color.White;
            cbSearchCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSearchCategory.ForeColor = Color.LightSeaGreen;
            cbSearchCategory.FormattingEnabled = true;
            cbSearchCategory.Location = new Point(731, 83);
            cbSearchCategory.Margin = new Padding(4);
            cbSearchCategory.Name = "cbSearchCategory";
            cbSearchCategory.Size = new Size(196, 33);
            cbSearchCategory.TabIndex = 15;
            cbSearchCategory.Text = "Select Category";
            cbSearchCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbSelectionCategory
            // 
            cbSelectionCategory.BackColor = Color.White;
            cbSelectionCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSelectionCategory.ForeColor = Color.LightSeaGreen;
            cbSelectionCategory.FormattingEnabled = true;
            cbSelectionCategory.Location = new Point(205, 423);
            cbSelectionCategory.Margin = new Padding(4);
            cbSelectionCategory.Name = "cbSelectionCategory";
            cbSelectionCategory.Size = new Size(196, 33);
            cbSelectionCategory.TabIndex = 14;
            cbSelectionCategory.Text = "Select Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(40, 420);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 32);
            label8.TabIndex = 11;
            label8.Text = "Category";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(205, 344);
            txtProductPrice.Margin = new Padding(4);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(196, 31);
            txtProductPrice.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(40, 343);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 9;
            label7.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(40, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 2;
            label4.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(379, -72);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(379, 32);
            label6.TabIndex = 17;
            label6.Text = "Supermarket Mangment System";
            // 
            // Product_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 793);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(btnCategories);
            Controls.Add(btnSellers);
            Controls.Add(btnSelling);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "Product_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product_form";
            Load += Product_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Productsdgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button5;
        private DataGridView Productsdgv;
        private Button btnAdd;
        private Button btnUpgrade;
        private Button btnDelete;
        private TextBox txtProductQuantity;
        private TextBox txtProductName;
        private Button btnCategories;
        private Button btnSellers;
        private TextBox txtProductID;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnSelling;
        private Panel panel1;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox txtProductPrice;
        private Label label7;
        private ComboBox cbSearchCategory;
        private ComboBox cbSelectionCategory;
        private Button button9;
    }
}