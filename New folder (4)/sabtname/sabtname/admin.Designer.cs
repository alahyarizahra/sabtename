namespace WindowsFormsApp4
{
    partial class admin
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
            this.دانشآموزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.معلمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کلاسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.report = new System.Windows.Forms.Button();
            this.delet = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ida = new System.Windows.Forms.TextBox();
            this.usa = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dataadmin = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دانشآموزToolStripMenuItem,
            this.معلمToolStripMenuItem,
            this.مدیرToolStripMenuItem,
            this.کلاسToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // دانشآموزToolStripMenuItem
            // 
            this.دانشآموزToolStripMenuItem.Name = "دانشآموزToolStripMenuItem";
            this.دانشآموزToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.دانشآموزToolStripMenuItem.Text = "دانش آموز";
            this.دانشآموزToolStripMenuItem.Click += new System.EventHandler(this.دانشآموزToolStripMenuItem_Click);
            // 
            // معلمToolStripMenuItem
            // 
            this.معلمToolStripMenuItem.Name = "معلمToolStripMenuItem";
            this.معلمToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.معلمToolStripMenuItem.Text = "معلم";
            this.معلمToolStripMenuItem.Click += new System.EventHandler(this.معلمToolStripMenuItem_Click);
            // 
            // مدیرToolStripMenuItem
            // 
            this.مدیرToolStripMenuItem.Name = "مدیرToolStripMenuItem";
            this.مدیرToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.مدیرToolStripMenuItem.Text = "مدیر";
            // 
            // کلاسToolStripMenuItem
            // 
            this.کلاسToolStripMenuItem.Name = "کلاسToolStripMenuItem";
            this.کلاسToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.کلاسToolStripMenuItem.Text = "کلاس";
            this.کلاسToolStripMenuItem.Click += new System.EventHandler(this.کلاسToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "کدکاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کاربری:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "رمزکاربری:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "ایمیل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "افزودن مدیر جدید";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 37);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.delet);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(418, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 156);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(128, 83);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(114, 46);
            this.report.TabIndex = 3;
            this.report.Text = "گزارش گیری";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // delet
            // 
            this.delet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.Location = new System.Drawing.Point(8, 83);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(114, 46);
            this.delet.TabIndex = 2;
            this.delet.Text = "حذف";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(128, 10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 46);
            this.update.TabIndex = 1;
            this.update.Text = "بروزرسانی";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(8, 10);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 46);
            this.save.TabIndex = 0;
            this.save.Text = "ذخیره";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ida
            // 
            this.ida.Location = new System.Drawing.Point(122, 102);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(186, 20);
            this.ida.TabIndex = 10;
            this.ida.TextChanged += new System.EventHandler(this.ida_TextChanged);
            // 
            // usa
            // 
            this.usa.Location = new System.Drawing.Point(122, 150);
            this.usa.Name = "usa";
            this.usa.Size = new System.Drawing.Size(186, 20);
            this.usa.TabIndex = 11;
            this.usa.TextChanged += new System.EventHandler(this.usa_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(122, 199);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(186, 20);
            this.pass.TabIndex = 12;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(122, 245);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(186, 20);
            this.email.TabIndex = 13;
            // 
            // dataadmin
            // 
            this.dataadmin.BackgroundColor = System.Drawing.Color.White;
            this.dataadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataadmin.Location = new System.Drawing.Point(12, 283);
            this.dataadmin.Name = "dataadmin";
            this.dataadmin.Size = new System.Drawing.Size(862, 135);
            this.dataadmin.TabIndex = 14;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(904, 424);
            this.Controls.Add(this.dataadmin);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usa);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "admin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیر";
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem دانشآموزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem معلمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کلاسToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox ida;
        private System.Windows.Forms.TextBox usa;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.DataGridView dataadmin;
    }
}