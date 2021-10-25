
namespace Grupp_28_RSS
{
    partial class FrmAvsnitt
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
            this.lbxKategorier = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAvsnitt = new System.Windows.Forms.ListBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbUppdateringsIntervall = new System.Windows.Forms.ComboBox();
            this.txtRSSURL = new System.Windows.Forms.TextBox();
            this.lvFeed = new System.Windows.Forms.ListView();
            this.lvChAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChIntervall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLaggTillURL = new System.Windows.Forms.Button();
            this.btnUppdateraFeed = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnAndraNamnKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblIntervall = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblTitelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txrNyKategori = new System.Windows.Forms.TextBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxKategorier
            // 
            this.lbxKategorier.FormattingEnabled = true;
            this.lbxKategorier.Items.AddRange(new object[] {
            "TestKategori1",
            "TestKategori2",
            "TestKategori3"});
            this.lbxKategorier.Location = new System.Drawing.Point(711, 28);
            this.lbxKategorier.Name = "lbxKategorier";
            this.lbxKategorier.Size = new System.Drawing.Size(223, 147);
            this.lbxKategorier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategorier:";
            // 
            // lbxAvsnitt
            // 
            this.lbxAvsnitt.FormattingEnabled = true;
            this.lbxAvsnitt.Location = new System.Drawing.Point(37, 311);
            this.lbxAvsnitt.Name = "lbxAvsnitt";
            this.lbxAvsnitt.Size = new System.Drawing.Size(633, 173);
            this.lbxAvsnitt.TabIndex = 2;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(34, 286);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(107, 13);
            this.lblAvsnitt.TabIndex = 3;
            this.lblAvsnitt.Text = "[RSSNamn]  : Avsnitt";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(325, 246);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(88, 21);
            this.cmbKategori.TabIndex = 4;
            // 
            // cmbUppdateringsIntervall
            // 
            this.cmbUppdateringsIntervall.FormattingEnabled = true;
            this.cmbUppdateringsIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbUppdateringsIntervall.Location = new System.Drawing.Point(232, 246);
            this.cmbUppdateringsIntervall.Name = "cmbUppdateringsIntervall";
            this.cmbUppdateringsIntervall.Size = new System.Drawing.Size(87, 21);
            this.cmbUppdateringsIntervall.TabIndex = 5;
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(37, 246);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(189, 20);
            this.txtRSSURL.TabIndex = 6;
            // 
            // lvFeed
            // 
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvChAvsnitt,
            this.lvChNamn,
            this.lvChIntervall,
            this.chKategori});
            this.lvFeed.HideSelection = false;
            this.lvFeed.Location = new System.Drawing.Point(37, 36);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(633, 182);
            this.lvFeed.TabIndex = 7;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            // 
            // lvChAvsnitt
            // 
            this.lvChAvsnitt.Text = "Avsnitt";
            // 
            // lvChNamn
            // 
            this.lvChNamn.Width = 145;
            // 
            // lvChIntervall
            // 
            this.lvChIntervall.Text = "Uppdateringsintervall";
            // 
            // chKategori
            // 
            this.chKategori.Text = "Kategori";
            // 
            // btnLaggTillURL
            // 
            this.btnLaggTillURL.Location = new System.Drawing.Point(429, 244);
            this.btnLaggTillURL.Name = "btnLaggTillURL";
            this.btnLaggTillURL.Size = new System.Drawing.Size(75, 23);
            this.btnLaggTillURL.TabIndex = 8;
            this.btnLaggTillURL.Text = "Lägg Till:";
            this.btnLaggTillURL.UseVisualStyleBackColor = true;
            // 
            // btnUppdateraFeed
            // 
            this.btnUppdateraFeed.Location = new System.Drawing.Point(514, 244);
            this.btnUppdateraFeed.Name = "btnUppdateraFeed";
            this.btnUppdateraFeed.Size = new System.Drawing.Size(75, 23);
            this.btnUppdateraFeed.TabIndex = 9;
            this.btnUppdateraFeed.Text = "Uppdatera:";
            this.btnUppdateraFeed.UseVisualStyleBackColor = true;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(595, 244);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 10;
            this.btnTaBort.Text = "Ta Bort:";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnAndraNamnKategori
            // 
            this.btnAndraNamnKategori.Location = new System.Drawing.Point(859, 244);
            this.btnAndraNamnKategori.Name = "btnAndraNamnKategori";
            this.btnAndraNamnKategori.Size = new System.Drawing.Size(75, 23);
            this.btnAndraNamnKategori.TabIndex = 11;
            this.btnAndraNamnKategori.Text = "Ändra Namn";
            this.btnAndraNamnKategori.UseVisualStyleBackColor = true;
            this.btnAndraNamnKategori.Click += new System.EventHandler(this.btnAndraNamnKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(711, 243);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(64, 23);
            this.btnLaggTillKategori.TabIndex = 12;
            this.btnLaggTillKategori.Text = "Lägg Till:";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(781, 243);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(57, 23);
            this.btnTaBortKategori.TabIndex = 13;
            this.btnTaBortKategori.Text = "Ta Bort:";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(34, 230);
            this.lblURL.Name = "lblURL";
            this.lblURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "URL:";
            // 
            // lblIntervall
            // 
            this.lblIntervall.AutoSize = true;
            this.lblIntervall.Location = new System.Drawing.Point(233, 230);
            this.lblIntervall.Name = "lblIntervall";
            this.lblIntervall.Size = new System.Drawing.Size(47, 13);
            this.lblIntervall.TabIndex = 15;
            this.lblIntervall.Text = "Intervall:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(325, 229);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 16;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblTitelDescription
            // 
            this.lblTitelDescription.AutoSize = true;
            this.lblTitelDescription.Location = new System.Drawing.Point(708, 286);
            this.lblTitelDescription.Name = "lblTitelDescription";
            this.lblTitelDescription.Size = new System.Drawing.Size(30, 13);
            this.lblTitelDescription.TabIndex = 17;
            this.lblTitelDescription.Text = "Title:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(711, 311);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 173);
            this.txtDescription.TabIndex = 18;
            // 
            // txrNyKategori
            // 
            this.txrNyKategori.Location = new System.Drawing.Point(711, 198);
            this.txrNyKategori.Name = "txrNyKategori";
            this.txrNyKategori.Size = new System.Drawing.Size(223, 20);
            this.txrNyKategori.TabIndex = 19;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(711, 182);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(116, 13);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Lägg till en ny kategori:";
            // 
            // FrmAvsnitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 537);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.txrNyKategori);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTitelDescription);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblIntervall);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.btnAndraNamnKategori);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnUppdateraFeed);
            this.Controls.Add(this.btnLaggTillURL);
            this.Controls.Add(this.lvFeed);
            this.Controls.Add(this.txtRSSURL);
            this.Controls.Add(this.cmbUppdateringsIntervall);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lbxAvsnitt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxKategorier);
            this.Name = "FrmAvsnitt";
            this.Text = "Really Simple Syndication by Grupp 28 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbUppdateringsIntervall;
        private System.Windows.Forms.TextBox txtRSSURL;
        private System.Windows.Forms.ListView lvFeed;
        private System.Windows.Forms.ColumnHeader lvChAvsnitt;
        private System.Windows.Forms.ColumnHeader lvChNamn;
        private System.Windows.Forms.ColumnHeader lvChIntervall;
        private System.Windows.Forms.ColumnHeader chKategori;
        private System.Windows.Forms.Button btnLaggTillURL;
        private System.Windows.Forms.Button btnUppdateraFeed;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnAndraNamnKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ListBox lbxAvsnitt;
        private System.Windows.Forms.Label lblIntervall;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblTitelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txrNyKategori;
        private System.Windows.Forms.Label lblNyKategori;
    }
}

