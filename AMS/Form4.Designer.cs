namespace AMS
{
    partial class Form4
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
            btnexit = new Button();
            btnin = new Button();
            groupBox1 = new GroupBox();
            tbpass = new TextBox();
            tbacc = new TextBox();
            cbpass = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(245, 193);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(114, 43);
            btnexit.TabIndex = 7;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnin
            // 
            btnin.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnin.Location = new Point(69, 193);
            btnin.Name = "btnin";
            btnin.Size = new Size(114, 43);
            btnin.TabIndex = 6;
            btnin.Text = "Log In";
            btnin.UseVisualStyleBackColor = true;
            btnin.Click += btnin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbpass);
            groupBox1.Controls.Add(tbacc);
            groupBox1.Controls.Add(cbpass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 116);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(98, 51);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(291, 27);
            tbpass.TabIndex = 4;
            tbpass.TextChanged += tbpass_TextChanged;
            // 
            // tbacc
            // 
            tbacc.Location = new Point(99, 22);
            tbacc.Name = "tbacc";
            tbacc.Size = new Size(291, 27);
            tbacc.TabIndex = 3;
            tbacc.TextChanged += tbacc_TextChanged;
            // 
            // cbpass
            // 
            cbpass.AutoSize = true;
            cbpass.Location = new Point(100, 79);
            cbpass.Name = "cbpass";
            cbpass.Size = new Size(132, 24);
            cbpass.TabIndex = 2;
            cbpass.Text = "Show Password";
            cbpass.UseVisualStyleBackColor = true;
            cbpass.CheckedChanged += cbpass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 55);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 0;
            label2.Text = "Account:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(363, 29);
            label1.TabIndex = 4;
            label1.Text = "Attendance Management System";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(437, 258);
            Controls.Add(btnexit);
            Controls.Add(btnin);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Log In";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Button btnin;
        private GroupBox groupBox1;
        private TextBox tbpass;
        private TextBox tbacc;
        private CheckBox cbpass;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}