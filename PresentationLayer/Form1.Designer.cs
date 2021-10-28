
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
            this.colFeedAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedIntervall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.txtPodcastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lbxKategorier.Sorted = true;
            this.lbxKategorier.TabIndex = 0;
            this.lbxKategorier.SelectedIndexChanged += new System.EventHandler(this.lbxKategorier_SelectedIndexChanged);
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
            this.lbxAvsnitt.Items.AddRange(new object[] {
            "HEJ",
            "fkfkfkf",
            "KUL"});
            this.lbxAvsnitt.Location = new System.Drawing.Point(37, 311);
            this.lbxAvsnitt.Name = "lbxAvsnitt";
            this.lbxAvsnitt.Size = new System.Drawing.Size(633, 212);
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
            this.cmbKategori.Location = new System.Drawing.Point(420, 245);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(88, 21);
            this.cmbKategori.Sorted = true;
            this.cmbKategori.TabIndex = 4;
            // 
            // cmbUppdateringsIntervall
            // 
            this.cmbUppdateringsIntervall.FormattingEnabled = true;
            this.cmbUppdateringsIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbUppdateringsIntervall.Location = new System.Drawing.Point(338, 245);
            this.cmbUppdateringsIntervall.Name = "cmbUppdateringsIntervall";
            this.cmbUppdateringsIntervall.Size = new System.Drawing.Size(63, 21);
            this.cmbUppdateringsIntervall.TabIndex = 5;
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(37, 245);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(189, 20);
            this.txtRSSURL.TabIndex = 6;
            this.txtRSSURL.Text = "https://www.svt.se/nyheter/rss.xml";
            // 
            // lvFeed
            // 
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFeedAvsnitt,
            this.colFeedNamn,
            this.colFeedIntervall,
            this.colFeedKategori});
            this.lvFeed.FullRowSelect = true;
            this.lvFeed.GridLines = true;
            this.lvFeed.HideSelection = false;
            this.lvFeed.LabelEdit = true;
            this.lvFeed.Location = new System.Drawing.Point(37, 36);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(668, 182);
            this.lvFeed.TabIndex = 7;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            this.lvFeed.SelectedIndexChanged += new System.EventHandler(this.lvFeed_SelectedIndexChanged);
            // 
            // colFeedAvsnitt
            // 
            this.colFeedAvsnitt.Text = "Avsnitt";
            // 
            // colFeedNamn
            // 
            this.colFeedNamn.Text = "Namn";
            this.colFeedNamn.Width = 198;
            // 
            // colFeedIntervall
            // 
            this.colFeedIntervall.Text = "Uppdateringsintervall";
            this.colFeedIntervall.Width = 229;
            // 
            // colFeedKategori
            // 
            this.colFeedKategori.Text = "Kategori";
            this.colFeedKategori.Width = 139;
            // 
            // btnLaggTillURL
            // 
            this.btnLaggTillURL.BackColor = System.Drawing.Color.Lime;
            this.btnLaggTillURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillURL.Location = new System.Drawing.Point(526, 230);
            this.btnLaggTillURL.Name = "btnLaggTillURL";
            this.btnLaggTillURL.Size = new System.Drawing.Size(48, 48);
            this.btnLaggTillURL.TabIndex = 8;
            this.btnLaggTillURL.Text = "➕";
            this.btnLaggTillURL.UseVisualStyleBackColor = false;
            this.btnLaggTillURL.Click += new System.EventHandler(this.btnLaggTillURL_Click);
            // 
            // btnUppdateraFeed
            // 
            this.btnUppdateraFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUppdateraFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnUppdateraFeed.Location = new System.Drawing.Point(634, 230);
            this.btnUppdateraFeed.Name = "btnUppdateraFeed";
            this.btnUppdateraFeed.Size = new System.Drawing.Size(48, 48);
            this.btnUppdateraFeed.TabIndex = 9;
            this.btnUppdateraFeed.Text = "♻";
            this.btnUppdateraFeed.UseVisualStyleBackColor = false;
            this.btnUppdateraFeed.Click += new System.EventHandler(this.btnUppdateraFeed_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTaBort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnTaBort.Location = new System.Drawing.Point(580, 230);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(48, 48);
            this.btnTaBort.TabIndex = 10;
            this.btnTaBort.Text = "❌";
            this.btnTaBort.UseVisualStyleBackColor = false;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
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
            this.btnLaggTillKategori.Location = new System.Drawing.Point(711, 244);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(64, 23);
            this.btnLaggTillKategori.TabIndex = 12;
            this.btnLaggTillKategori.Text = "Lägg Till:";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(781, 244);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(57, 23);
            this.btnTaBortKategori.TabIndex = 13;
            this.btnTaBortKategori.Text = "Ta Bort:";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
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
            this.lblIntervall.Location = new System.Drawing.Point(335, 227);
            this.lblIntervall.Name = "lblIntervall";
            this.lblIntervall.Size = new System.Drawing.Size(47, 13);
            this.lblIntervall.TabIndex = 15;
            this.lblIntervall.Text = "Intervall:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(417, 227);
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
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(676, 302);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 223);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.Location = new System.Drawing.Point(711, 198);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(223, 20);
            this.txtNyKategori.TabIndex = 19;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(711, 182);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(263, 13);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Lägg till en ny kategor / Ändra namn på vald kategorii:";
            // 
            // txtPodcastName
            // 
            this.txtPodcastName.Location = new System.Drawing.Point(232, 245);
            this.txtPodcastName.Name = "txtPodcastName";
            this.txtPodcastName.Size = new System.Drawing.Size(100, 20);
            this.txtPodcastName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Podcasts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Namn:";
            // 
            // FrmAvsnitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPodcastName);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.txtNyKategori);
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
            this.Load += new System.EventHandler(this.FrmAvsnitt_Load);
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
        private System.Windows.Forms.ColumnHeader colFeedAvsnitt;
        private System.Windows.Forms.ColumnHeader colFeedNamn;
        private System.Windows.Forms.ColumnHeader colFeedIntervall;
        private System.Windows.Forms.ColumnHeader colFeedKategori;
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
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.TextBox txtPodcastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

