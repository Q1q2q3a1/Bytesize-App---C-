
namespace LoginEx
{
    partial class Form1
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
            this.lblStudLogin = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtStudNum = new System.Windows.Forms.TextBox();
            this.txtPword = new System.Windows.Forms.TextBox();
            this.btnStudLogin = new System.Windows.Forms.Button();
            this.lblStudNoLogin = new System.Windows.Forms.Label();
            this.lblStudpsswrdLogin = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStudLogin
            // 
            this.lblStudLogin.AutoSize = true;
            this.lblStudLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblStudLogin.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudLogin.ForeColor = System.Drawing.Color.White;
            this.lblStudLogin.Location = new System.Drawing.Point(66, 55);
            this.lblStudLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudLogin.Name = "lblStudLogin";
            this.lblStudLogin.Size = new System.Drawing.Size(124, 42);
            this.lblStudLogin.TabIndex = 15;
            this.lblStudLogin.Text = "LOGIN";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(73, 345);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 40);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtStudNum
            // 
            this.txtStudNum.Location = new System.Drawing.Point(73, 146);
            this.txtStudNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(246, 20);
            this.txtStudNum.TabIndex = 17;
            // 
            // txtPword
            // 
            this.txtPword.Location = new System.Drawing.Point(73, 200);
            this.txtPword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPword.Name = "txtPword";
            this.txtPword.PasswordChar = '*';
            this.txtPword.Size = new System.Drawing.Size(246, 20);
            this.txtPword.TabIndex = 18;
            // 
            // btnStudLogin
            // 
            this.btnStudLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudLogin.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudLogin.Location = new System.Drawing.Point(73, 269);
            this.btnStudLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStudLogin.Name = "btnStudLogin";
            this.btnStudLogin.Size = new System.Drawing.Size(180, 43);
            this.btnStudLogin.TabIndex = 20;
            this.btnStudLogin.Text = "Login";
            this.btnStudLogin.UseVisualStyleBackColor = false;
            this.btnStudLogin.Click += new System.EventHandler(this.btnStudLogin_Click);
            // 
            // lblStudNoLogin
            // 
            this.lblStudNoLogin.AutoSize = true;
            this.lblStudNoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblStudNoLogin.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNoLogin.ForeColor = System.Drawing.Color.White;
            this.lblStudNoLogin.Location = new System.Drawing.Point(71, 129);
            this.lblStudNoLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudNoLogin.Name = "lblStudNoLogin";
            this.lblStudNoLogin.Size = new System.Drawing.Size(124, 15);
            this.lblStudNoLogin.TabIndex = 22;
            this.lblStudNoLogin.Text = "STUDENT NUMBER";
            // 
            // lblStudpsswrdLogin
            // 
            this.lblStudpsswrdLogin.AutoSize = true;
            this.lblStudpsswrdLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblStudpsswrdLogin.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudpsswrdLogin.ForeColor = System.Drawing.Color.White;
            this.lblStudpsswrdLogin.Location = new System.Drawing.Point(71, 182);
            this.lblStudpsswrdLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudpsswrdLogin.Name = "lblStudpsswrdLogin";
            this.lblStudpsswrdLogin.Size = new System.Drawing.Size(77, 15);
            this.lblStudpsswrdLogin.TabIndex = 27;
            this.lblStudpsswrdLogin.Text = "PASSWORD";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(303, 269);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 43);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(212, 182);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 18);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bytesize_App.Properties.Resources.WhatsApp_Image_2022_10_12_at_12_41_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 422);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblStudpsswrdLogin);
            this.Controls.Add(this.lblStudNoLogin);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStudLogin);
            this.Controls.Add(this.txtPword);
            this.Controls.Add(this.txtStudNum);
            this.Controls.Add(this.lblStudLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login Page";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudLogin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtStudNum;
        private System.Windows.Forms.TextBox txtPword;
        private System.Windows.Forms.Button btnStudLogin;
        private System.Windows.Forms.Label lblStudNoLogin;
        private System.Windows.Forms.Label lblStudpsswrdLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}