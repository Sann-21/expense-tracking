
namespace Expense_Tracking
{
    partial class regForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.linkLg = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.lbwarn1 = new System.Windows.Forms.Label();
            this.lbwarn2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.02422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.97578F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reg_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.linkLg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.reg_password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbwarn1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbwarn2, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(216, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 275);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(136, 3);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(221, 28);
            this.reg_username.TabIndex = 2;
            this.reg_username.TextChanged += new System.EventHandler(this.reg_username_TextChanged);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReg.Location = new System.Drawing.Point(136, 224);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(221, 48);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // linkLg
            // 
            this.linkLg.AutoSize = true;
            this.linkLg.Location = new System.Drawing.Point(136, 177);
            this.linkLg.Name = "linkLg";
            this.linkLg.Size = new System.Drawing.Size(43, 17);
            this.linkLg.TabIndex = 5;
            this.linkLg.TabStop = true;
            this.linkLg.Text = "Login";
            this.linkLg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLg_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(136, 86);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(221, 28);
            this.reg_password.TabIndex = 3;
            this.reg_password.TextChanged += new System.EventHandler(this.reg_password_TextChanged);
            // 
            // lbwarn1
            // 
            this.lbwarn1.AutoSize = true;
            this.lbwarn1.ForeColor = System.Drawing.Color.Red;
            this.lbwarn1.Location = new System.Drawing.Point(136, 50);
            this.lbwarn1.Name = "lbwarn1";
            this.lbwarn1.Size = new System.Drawing.Size(189, 17);
            this.lbwarn1.TabIndex = 6;
            this.lbwarn1.Text = "Use Only Letter and Number";
            this.lbwarn1.Visible = false;
            // 
            // lbwarn2
            // 
            this.lbwarn2.AutoSize = true;
            this.lbwarn2.ForeColor = System.Drawing.Color.Red;
            this.lbwarn2.Location = new System.Drawing.Point(136, 131);
            this.lbwarn2.Name = "lbwarn2";
            this.lbwarn2.Size = new System.Drawing.Size(210, 34);
            this.lbwarn2.TabIndex = 7;
            this.lbwarn2.Text = "Use at least 8 characters with 1 Upper and 1 lower character\r\n";
            this.lbwarn2.Visible = false;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "regForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.LinkLabel linkLg;
        private System.Windows.Forms.Label lbwarn1;
        private System.Windows.Forms.Label lbwarn2;
    }
}