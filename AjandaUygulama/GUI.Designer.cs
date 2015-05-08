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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAll
            // 
            this.lstAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 17;
            this.lstAll.Location = new System.Drawing.Point(10, 45);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(169, 326);
            this.lstAll.TabIndex = 0;
            // 
            // lstDurum
            // 
            this.lstDurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.ItemHeight = 17;
            this.lstDurum.Location = new System.Drawing.Point(179, 45);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(182, 326);
            this.lstDurum.TabIndex = 1;
            // 
            // lstResim
            // 
            this.lstResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstResim.FormattingEnabled = true;
            this.lstResim.ItemHeight = 17;
            this.lstResim.Location = new System.Drawing.Point(361, 45);
            this.lstResim.Name = "lstResim";
            this.lstResim.Size = new System.Drawing.Size(182, 326);
            this.lstResim.TabIndex = 2;
            // 
            // lstYazi
            // 
            this.lstYazi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstYazi.FormattingEnabled = true;
            this.lstYazi.ItemHeight = 17;
            this.lstYazi.Location = new System.Drawing.Point(543, 45);
            this.lstYazi.Name = "lstYazi";
            this.lstYazi.Size = new System.Drawing.Size(182, 326);
            this.lstYazi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tümü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(175, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(357, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(539, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yazı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(731, 45);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(51, 68);
            this.btnYeni.TabIndex = 8;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(731, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYazi);
            this.Controls.Add(this.lstResim);
            this.Controls.Add(this.lstDurum);
            this.Controls.Add(this.lstAll);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.Text = ":: Ahmed Şeref GÜNEYSU ::";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.ListBox lstDurum;
        private System.Windows.Forms.ListBox lstResim;
        private System.Windows.Forms.ListBox lstYazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button button1;
    }
}

