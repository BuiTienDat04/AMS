namespace AMS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            dgvINS = new DataGridView();
            label2 = new Label();
            tbUSERINS = new TextBox();
            btnExitINS = new Button();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            btnAtten2 = new Button();
            btnclass2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvINS).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(606, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dgvINS
            // 
            dgvINS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvINS.Location = new Point(169, 110);
            dgvINS.Name = "dgvINS";
            dgvINS.RowHeadersWidth = 51;
            dgvINS.RowTemplate.Height = 29;
            dgvINS.Size = new Size(600, 328);
            dgvINS.TabIndex = 3;
            dgvINS.CellContentClick += dgvINS_CellContentClick;
            dgvINS.CellValueChanged += dgvINS_CellValueChanged;
            dgvINS.DataBindingComplete += dgvINS_DataBindingComplete;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 4;
            label2.Text = "User:";
            // 
            // tbUSERINS
            // 
            tbUSERINS.Location = new Point(65, 31);
            tbUSERINS.Name = "tbUSERINS";
            tbUSERINS.ReadOnly = true;
            tbUSERINS.Size = new Size(226, 27);
            tbUSERINS.TabIndex = 5;
            tbUSERINS.TextChanged += tbUSERINS_TextChanged;
            // 
            // btnExitINS
            // 
            btnExitINS.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitINS.Location = new Point(23, 280);
            btnExitINS.Name = "btnExitINS";
            btnExitINS.Size = new Size(114, 31);
            btnExitINS.TabIndex = 6;
            btnExitINS.Text = "Exit";
            btnExitINS.UseVisualStyleBackColor = true;
            btnExitINS.Click += btnExitINS_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnAtten2);
            groupBox1.Controls.Add(btnExitINS);
            groupBox1.Controls.Add(btnclass2);
            groupBox1.Location = new Point(2, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 317);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(33, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAtten2
            // 
            btnAtten2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtten2.Location = new Point(33, 68);
            btnAtten2.Name = "btnAtten2";
            btnAtten2.Size = new Size(94, 29);
            btnAtten2.TabIndex = 1;
            btnAtten2.Text = "Attendance";
            btnAtten2.UseVisualStyleBackColor = true;
            btnAtten2.Click += btnAtten2_Click;
            // 
            // btnclass2
            // 
            btnclass2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnclass2.Location = new Point(33, 26);
            btnclass2.Name = "btnclass2";
            btnclass2.Size = new Size(94, 29);
            btnclass2.TabIndex = 0;
            btnclass2.Text = "Class";
            btnclass2.UseVisualStyleBackColor = true;
            btnclass2.Click += btnclass2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2023_11_22_172623_1_;
            pictureBox2.Location = new Point(333, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(782, 443);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(tbUSERINS);
            Controls.Add(label2);
            Controls.Add(dgvINS);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Attendance System (Instructors)";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvINS).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvINS;
        private Label label2;
        private TextBox tbUSERINS;
        private Button btnoutINS;
        private GroupBox groupBox1;
        private Button btnAtten2;
        private Button btnclass2;
        private PictureBox pictureBox2;
        private Button btnSave;
        private Button btnExitINS;
    }
}