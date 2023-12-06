namespace AMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dgvSTU = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbUSER = new TextBox();
            btnExitSTU = new Button();
            groupBox1 = new GroupBox();
            btnatten1 = new Button();
            btnclass1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSTU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvSTU
            // 
            dgvSTU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSTU.Location = new Point(161, 110);
            dgvSTU.Name = "dgvSTU";
            dgvSTU.ReadOnly = true;
            dgvSTU.RowHeadersWidth = 51;
            dgvSTU.RowTemplate.Height = 29;
            dgvSTU.Size = new Size(610, 328);
            dgvSTU.TabIndex = 0;
            dgvSTU.CellContentClick += dgvSTU_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(609, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 3;
            label2.Text = "User:";
            // 
            // tbUSER
            // 
            tbUSER.Location = new Point(59, 28);
            tbUSER.Name = "tbUSER";
            tbUSER.ReadOnly = true;
            tbUSER.Size = new Size(226, 27);
            tbUSER.TabIndex = 4;
            tbUSER.TextChanged += tbUSER_TextChanged;
            // 
            // btnExitSTU
            // 
            btnExitSTU.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitSTU.Location = new Point(16, 280);
            btnExitSTU.Name = "btnExitSTU";
            btnExitSTU.Size = new Size(114, 31);
            btnExitSTU.TabIndex = 5;
            btnExitSTU.Text = "Exit";
            btnExitSTU.UseVisualStyleBackColor = true;
            btnExitSTU.Click += btnExitSTU_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnatten1);
            groupBox1.Controls.Add(btnExitSTU);
            groupBox1.Controls.Add(btnclass1);
            groupBox1.Location = new Point(6, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 317);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnatten1
            // 
            btnatten1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnatten1.Location = new Point(25, 68);
            btnatten1.Name = "btnatten1";
            btnatten1.Size = new Size(94, 29);
            btnatten1.TabIndex = 1;
            btnatten1.Text = "Attendance";
            btnatten1.UseVisualStyleBackColor = true;
            btnatten1.Click += btnatten1_Click;
            // 
            // btnclass1
            // 
            btnclass1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnclass1.Location = new Point(25, 26);
            btnclass1.Name = "btnclass1";
            btnclass1.Size = new Size(94, 29);
            btnclass1.TabIndex = 0;
            btnclass1.Text = "Class";
            btnclass1.UseVisualStyleBackColor = true;
            btnclass1.Click += btnclass1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_11_22_172652;
            pictureBox2.Location = new Point(341, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(782, 444);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(tbUSER);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvSTU);
            Name = "Form2";
            Text = "Attendance System (Students)";
            ((System.ComponentModel.ISupportInitialize)dgvSTU).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSTU;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbUSER;
        private Button btnExitSTU;
        private GroupBox groupBox1;
        private Button btnatten1;
        private Button btnclass1;
        private PictureBox pictureBox2;
    }
}