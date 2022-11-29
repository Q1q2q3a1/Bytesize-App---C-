
namespace Bytesize_App
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAcademicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAcademicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.btnInsurance = new System.Windows.Forms.Button();
            this.lblMCourse = new System.Windows.Forms.Label();
            this.lblIID = new System.Windows.Forms.Label();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(718, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.toolStripComboBox1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAcademicToolStripMenuItem,
            this.createNewQuizToolStripMenuItem});
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewToolStripMenuItem.Text = "New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // createNewAcademicToolStripMenuItem
            // 
            this.createNewAcademicToolStripMenuItem.Name = "createNewAcademicToolStripMenuItem";
            this.createNewAcademicToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.createNewAcademicToolStripMenuItem.Text = "Create New Academic";
            this.createNewAcademicToolStripMenuItem.Click += new System.EventHandler(this.createNewAcademicToolStripMenuItem_Click);
            // 
            // createNewQuizToolStripMenuItem
            // 
            this.createNewQuizToolStripMenuItem.Name = "createNewQuizToolStripMenuItem";
            this.createNewQuizToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.createNewQuizToolStripMenuItem.Text = "Create New Quiz";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAcademicToolStripMenuItem,
            this.updateFeedbackToolStripMenuItem,
            this.updateQuizToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // updateAcademicToolStripMenuItem
            // 
            this.updateAcademicToolStripMenuItem.Name = "updateAcademicToolStripMenuItem";
            this.updateAcademicToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateAcademicToolStripMenuItem.Text = "Update Academic";
            this.updateAcademicToolStripMenuItem.Click += new System.EventHandler(this.updateAcademicToolStripMenuItem_Click);
            // 
            // updateFeedbackToolStripMenuItem
            // 
            this.updateFeedbackToolStripMenuItem.Name = "updateFeedbackToolStripMenuItem";
            this.updateFeedbackToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateFeedbackToolStripMenuItem.Text = "Update Feedback";
            this.updateFeedbackToolStripMenuItem.Click += new System.EventHandler(this.updateFeedbackToolStripMenuItem_Click);
            // 
            // updateQuizToolStripMenuItem
            // 
            this.updateQuizToolStripMenuItem.Name = "updateQuizToolStripMenuItem";
            this.updateQuizToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateQuizToolStripMenuItem.Text = "Update Quiz";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this.lblCID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCourse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPublished, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsurance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMCourse, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIID, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMarketing, 1, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(130, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 222);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(337, 0);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(81, 20);
            this.lblCID.TabIndex = 2;
            this.lblCID.Text = "Course ID";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(170, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(68, 20);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Courses";
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublished.Location = new System.Drawing.Point(3, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(78, 20);
            this.lblPublished.TabIndex = 0;
            this.lblPublished.Text = "Published";
            // 
            // btnInsurance
            // 
            this.btnInsurance.Location = new System.Drawing.Point(170, 128);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Size = new System.Drawing.Size(75, 23);
            this.btnInsurance.TabIndex = 4;
            this.btnInsurance.Text = "Insurance";
            this.btnInsurance.UseVisualStyleBackColor = true;
            // 
            // lblMCourse
            // 
            this.lblMCourse.AutoSize = true;
            this.lblMCourse.Location = new System.Drawing.Point(337, 39);
            this.lblMCourse.Name = "lblMCourse";
            this.lblMCourse.Size = new System.Drawing.Size(40, 13);
            this.lblMCourse.TabIndex = 5;
            this.lblMCourse.Text = "M1001";
            // 
            // lblIID
            // 
            this.lblIID.AutoSize = true;
            this.lblIID.Location = new System.Drawing.Point(337, 125);
            this.lblIID.Name = "lblIID";
            this.lblIID.Size = new System.Drawing.Size(34, 13);
            this.lblIID.TabIndex = 6;
            this.lblIID.Text = "I1000";
            // 
            // btnMarketing
            // 
            this.btnMarketing.Location = new System.Drawing.Point(170, 42);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(75, 23);
            this.btnMarketing.TabIndex = 3;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bytesize_App.Properties.Resources.WhatsApp_Image_2022_10_12_at_12_41_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAcademicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAcademicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQuizToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblPublished;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Label lblMCourse;
        private System.Windows.Forms.Label lblIID;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}