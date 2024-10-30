namespace ARCHON_SYSTEM
{
    partial class frmOpeningForm
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
            this.components = new System.ComponentModel.Container();
            this.pBAR = new System.Windows.Forms.ProgressBar();
            this.photoPrinter = new System.Windows.Forms.PictureBox();
            this.labCommerc01 = new System.Windows.Forms.Label();
            this.labCommerc02 = new System.Windows.Forms.Label();
            this.labCommerc03 = new System.Windows.Forms.Label();
            this.labCommerc04 = new System.Windows.Forms.Label();
            this.tickerOpening = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.photoPrinter)).BeginInit();
            this.SuspendLayout();
            // 
            // pBAR
            // 
            this.pBAR.Location = new System.Drawing.Point(12, 405);
            this.pBAR.Name = "pBAR";
            this.pBAR.Size = new System.Drawing.Size(768, 15);
            this.pBAR.TabIndex = 0;
            // 
            // photoPrinter
            // 
            this.photoPrinter.BackgroundImage = global::ARCHON_SYSTEM.Properties.Resources.UX2_PROFILE;
            this.photoPrinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPrinter.Location = new System.Drawing.Point(12, 12);
            this.photoPrinter.Name = "photoPrinter";
            this.photoPrinter.Size = new System.Drawing.Size(332, 365);
            this.photoPrinter.TabIndex = 1;
            this.photoPrinter.TabStop = false;
            // 
            // labCommerc01
            // 
            this.labCommerc01.AutoSize = true;
            this.labCommerc01.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCommerc01.Location = new System.Drawing.Point(399, 50);
            this.labCommerc01.Name = "labCommerc01";
            this.labCommerc01.Size = new System.Drawing.Size(348, 46);
            this.labCommerc01.TabIndex = 2;
            this.labCommerc01.Text = "HITACHI INKJET";
            // 
            // labCommerc02
            // 
            this.labCommerc02.AutoSize = true;
            this.labCommerc02.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCommerc02.Location = new System.Drawing.Point(464, 96);
            this.labCommerc02.Name = "labCommerc02";
            this.labCommerc02.Size = new System.Drawing.Size(200, 46);
            this.labCommerc02.TabIndex = 3;
            this.labCommerc02.Text = "PRINTER";
            // 
            // labCommerc03
            // 
            this.labCommerc03.AutoSize = true;
            this.labCommerc03.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCommerc03.Location = new System.Drawing.Point(467, 154);
            this.labCommerc03.Name = "labCommerc03";
            this.labCommerc03.Size = new System.Drawing.Size(197, 93);
            this.labCommerc03.TabIndex = 4;
            this.labCommerc03.Text = "UX2";
            // 
            // labCommerc04
            // 
            this.labCommerc04.AutoSize = true;
            this.labCommerc04.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCommerc04.Location = new System.Drawing.Point(648, 212);
            this.labCommerc04.Name = "labCommerc04";
            this.labCommerc04.Size = new System.Drawing.Size(82, 22);
            this.labCommerc04.TabIndex = 5;
            this.labCommerc04.Text = "SERIES";
            // 
            // tickerOpening
            // 
            this.tickerOpening.Interval = 50;
            this.tickerOpening.Tick += new System.EventHandler(this.tickerOpening_Tick);
            // 
            // frmOpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 432);
            this.ControlBox = false;
            this.Controls.Add(this.labCommerc04);
            this.Controls.Add(this.labCommerc03);
            this.Controls.Add(this.labCommerc02);
            this.Controls.Add(this.labCommerc01);
            this.Controls.Add(this.photoPrinter);
            this.Controls.Add(this.pBAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpeningForm";
            this.Load += new System.EventHandler(this.frmOpeningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPrinter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBAR;
        private System.Windows.Forms.PictureBox photoPrinter;
        private System.Windows.Forms.Label labCommerc01;
        private System.Windows.Forms.Label labCommerc02;
        private System.Windows.Forms.Label labCommerc03;
        private System.Windows.Forms.Label labCommerc04;
        private System.Windows.Forms.Timer tickerOpening;
    }
}