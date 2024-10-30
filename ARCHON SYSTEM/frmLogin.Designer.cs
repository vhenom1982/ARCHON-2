namespace ARCHON_SYSTEM
{
    partial class frmLogin
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.labUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labLogCap = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(355, 141);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(101, 27);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.Blue;
            this.labUserName.Location = new System.Drawing.Point(28, 59);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(83, 17);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(117, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(339, 26);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "ABCDERFGHI";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // labLogCap
            // 
            this.labLogCap.AutoSize = true;
            this.labLogCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogCap.ForeColor = System.Drawing.Color.Blue;
            this.labLogCap.Location = new System.Drawing.Point(28, 19);
            this.labLogCap.Name = "labLogCap";
            this.labLogCap.Size = new System.Drawing.Size(293, 17);
            this.labLogCap.TabIndex = 3;
            this.labLogCap.Text = "Please inoutn username and password:";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ForeColor = System.Drawing.Color.Blue;
            this.labPassword.Location = new System.Drawing.Point(28, 103);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(73, 17);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(117, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '♥';
            this.txtPassword.Size = new System.Drawing.Size(339, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "ABCDERFGHI";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(248, 141);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(101, 27);
            this.cmdLogin.TabIndex = 7;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 178);
            this.ControlBox = false;
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labLogCap);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archon Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labLogCap;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdLogin;
    }
}