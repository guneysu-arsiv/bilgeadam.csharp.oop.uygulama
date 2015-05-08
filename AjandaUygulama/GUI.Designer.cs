namespace AjandaUygulama
{
    partial class GUI
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
            this.lstAll = new System.Windows.Forms.ListBox();
            this.lstDurum = new System.Windows.Forms.ListBox();
            this.lstResim = new System.Windows.Forms.ListBox();
            this.lstYazi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAll
            // 
            this.lstAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 17;
            this.lstAll.Location = new System.Drawing.Point(10, 10);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(182, 361);
            this.lstAll.TabIndex = 0;
            // 
            // lstDurum
            // 
            this.lstDurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.ItemHeight = 17;
            this.lstDurum.Location = new System.Drawing.Point(192, 10);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(182, 361);
            this.lstDurum.TabIndex = 1;
            // 
            // lstResim
            // 
            this.lstResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstResim.FormattingEnabled = true;
            this.lstResim.ItemHeight = 17;
            this.lstResim.Location = new System.Drawing.Point(374, 10);
            this.lstResim.Name = "lstResim";
            this.lstResim.Size = new System.Drawing.Size(182, 361);
            this.lstResim.TabIndex = 2;
            // 
            // lstYazi
            // 
            this.lstYazi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstYazi.FormattingEnabled = true;
            this.lstYazi.ItemHeight = 17;
            this.lstYazi.Location = new System.Drawing.Point(556, 10);
            this.lstYazi.Name = "lstYazi";
            this.lstYazi.Size = new System.Drawing.Size(182, 361);
            this.lstYazi.TabIndex = 3;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 381);
            this.Controls.Add(this.lstYazi);
            this.Controls.Add(this.lstResim);
            this.Controls.Add(this.lstDurum);
            this.Controls.Add(this.lstAll);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = ":: Ahmed Şeref GÜNEYSU ::";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.ListBox lstDurum;
        private System.Windows.Forms.ListBox lstResim;
        private System.Windows.Forms.ListBox lstYazi;
    }
}

