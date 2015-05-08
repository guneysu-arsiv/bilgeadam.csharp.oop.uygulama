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
            this.btnDurum = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnYazi = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.dtpFiltre = new System.Windows.Forms.DateTimePicker();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAll
            // 
            this.lstAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 17;
            this.lstAll.Location = new System.Drawing.Point(10, 45);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(169, 296);
            this.lstAll.TabIndex = 0;
            // 
            // lstDurum
            // 
            this.lstDurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstDurum.FormattingEnabled = true;
            this.lstDurum.ItemHeight = 17;
            this.lstDurum.Location = new System.Drawing.Point(179, 45);
            this.lstDurum.Name = "lstDurum";
            this.lstDurum.Size = new System.Drawing.Size(182, 296);
            this.lstDurum.TabIndex = 1;
            // 
            // lstResim
            // 
            this.lstResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstResim.FormattingEnabled = true;
            this.lstResim.ItemHeight = 17;
            this.lstResim.Location = new System.Drawing.Point(361, 45);
            this.lstResim.Name = "lstResim";
            this.lstResim.Size = new System.Drawing.Size(182, 296);
            this.lstResim.TabIndex = 2;
            // 
            // lstYazi
            // 
            this.lstYazi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstYazi.FormattingEnabled = true;
            this.lstYazi.ItemHeight = 17;
            this.lstYazi.Location = new System.Drawing.Point(543, 45);
            this.lstYazi.Name = "lstYazi";
            this.lstYazi.Size = new System.Drawing.Size(182, 296);
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
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurum.Location = new System.Drawing.Point(730, 48);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(63, 40);
            this.btnDurum.TabIndex = 9;
            this.btnDurum.Text = "Durum";
            this.btnDurum.UseVisualStyleBackColor = false;
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResim.Location = new System.Drawing.Point(730, 94);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(63, 40);
            this.btnResim.TabIndex = 10;
            this.btnResim.Text = "Resim";
            this.btnResim.UseVisualStyleBackColor = false;
            // 
            // btnYazi
            // 
            this.btnYazi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazi.Location = new System.Drawing.Point(730, 140);
            this.btnYazi.Name = "btnYazi";
            this.btnYazi.Size = new System.Drawing.Size(63, 40);
            this.btnYazi.TabIndex = 11;
            this.btnYazi.Text = "Yazı";
            this.btnYazi.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(730, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 40);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Tümü";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(731, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 99);
            this.label5.TabIndex = 13;
            this.label5.Text = "Silmek İstediğiniz Elemanı Çift Tıklayın :) Aşağıdan Tarih Seçip Kayıtları Filter" +
    "eleyebilirsiniz.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.Turquoise;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Location = new System.Drawing.Point(730, 232);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(63, 40);
            this.btnFiltrele.TabIndex = 14;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            // 
            // dtpFiltre
            // 
            this.dtpFiltre.Location = new System.Drawing.Point(543, 347);
            this.dtpFiltre.Name = "dtpFiltre";
            this.dtpFiltre.Size = new System.Drawing.Size(182, 25);
            this.dtpFiltre.TabIndex = 15;
            // 
            // btnSerialize
            // 
            this.btnSerialize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialize.Location = new System.Drawing.Point(799, 48);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(94, 40);
            this.btnSerialize.TabIndex = 16;
            this.btnSerialize.Text = "Dosyaya";
            this.btnSerialize.UseVisualStyleBackColor = false;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.BackColor = System.Drawing.Color.Turquoise;
            this.btnDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeserialize.Location = new System.Drawing.Point(799, 94);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(94, 40);
            this.btnDeserialize.TabIndex = 17;
            this.btnDeserialize.Text = "Dosyadan";
            this.btnDeserialize.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 381);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.dtpFiltre);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnYazi);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstYazi);
            this.Controls.Add(this.lstResim);
            this.Controls.Add(this.lstDurum);
            this.Controls.Add(this.lstAll);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 40);
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
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnYazi;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.DateTimePicker dtpFiltre;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
    }
}

