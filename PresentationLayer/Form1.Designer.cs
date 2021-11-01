
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
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lvFeed = new System.Windows.Forms.ListView();
            this.colFeedAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedIntervall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedSenastUppdaterad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.colAvsnittNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvsnittTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPodcastName = new System.Windows.Forms.TextBox();
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblIntervall = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnAndraNamnKategori = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnUppdateraFeed = new System.Windows.Forms.Button();
            this.btnLaggTillURL = new System.Windows.Forms.Button();
            this.txtRSSURL = new System.Windows.Forms.TextBox();
            this.cmbUppdateringsIntervall = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.tabReader = new System.Windows.Forms.TabControl();
            this.tabPageNewsReader = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxNewsReaderKategori = new System.Windows.Forms.ListBox();
            this.tabPageNewsManager = new System.Windows.Forms.TabPage();
            this.lbxPodcastNamesToDelete = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageKategoriManager = new System.Windows.Forms.TabPage();
            this.tabReader.SuspendLayout();
            this.tabPageNewsReader.SuspendLayout();
            this.tabPageNewsManager.SuspendLayout();
            this.tabPageKategoriManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxKategorier
            // 
            this.lbxKategorier.FormattingEnabled = true;
            this.lbxKategorier.ItemHeight = 16;
            this.lbxKategorier.Items.AddRange(new object[] {
            "TestKategori1",
            "TestKategori2",
            "TestKategori3"});
            this.lbxKategorier.Location = new System.Drawing.Point(35, 124);
            this.lbxKategorier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxKategorier.Name = "lbxKategorier";
            this.lbxKategorier.Size = new System.Drawing.Size(335, 212);
            this.lbxKategorier.TabIndex = 0;
            this.lbxKategorier.SelectedIndexChanged += new System.EventHandler(this.lbxKategorier_SelectedIndexChanged);
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(719, 23);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(50, 17);
            this.lblAvsnitt.TabIndex = 3;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // lvFeed
            // 
            this.lvFeed.AllowColumnReorder = true;
            this.lvFeed.BackColor = System.Drawing.SystemColors.Window;
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFeedAvsnitt,
            this.colFeedNamn,
            this.colFeedIntervall,
            this.colFeedKategori,
            this.colFeedSenastUppdaterad});
            this.lvFeed.FullRowSelect = true;
            this.lvFeed.GridLines = true;
            this.lvFeed.HideSelection = false;
            this.lvFeed.Location = new System.Drawing.Point(169, 43);
            this.lvFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvFeed.MultiSelect = false;
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(548, 350);
            this.lvFeed.TabIndex = 7;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            this.lvFeed.SelectedIndexChanged += new System.EventHandler(this.lvFeed_SelectedIndexChanged);
            // 
            // colFeedAvsnitt
            // 
            this.colFeedAvsnitt.Text = "Avsnitt";
            this.colFeedAvsnitt.Width = 35;
            // 
            // colFeedNamn
            // 
            this.colFeedNamn.Text = "Namn";
            this.colFeedNamn.Width = 140;
            // 
            // colFeedIntervall
            // 
            this.colFeedIntervall.Text = "Uppdateringsintervall";
            this.colFeedIntervall.Width = 30;
            // 
            // colFeedKategori
            // 
            this.colFeedKategori.Text = "Kategori";
            this.colFeedKategori.Width = 80;
            // 
            // colFeedSenastUppdaterad
            // 
            this.colFeedSenastUppdaterad.Text = "Senast uppdaterad";
            this.colFeedSenastUppdaterad.Width = 110;
            // 
            // lblTitelDescription
            // 
            this.lblTitelDescription.AutoSize = true;
            this.lblTitelDescription.Location = new System.Drawing.Point(8, 410);
            this.lblTitelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitelDescription.Name = "lblTitelDescription";
            this.lblTitelDescription.Size = new System.Drawing.Size(49, 17);
            this.lblTitelDescription.TabIndex = 17;
            this.lblTitelDescription.Text = "Nyhet:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(8, 430);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1284, 313);
            this.txtDescription.TabIndex = 18;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(31, 105);
            this.lblNyKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(74, 17);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Kategorier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Podcasts:";
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.AllowColumnReorder = true;
            this.lvAvsnitt.AllowDrop = true;
            this.lvAvsnitt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAvsnittNr,
            this.colAvsnittTitel});
            this.lvAvsnitt.FullRowSelect = true;
            this.lvAvsnitt.GridLines = true;
            this.lvAvsnitt.HideSelection = false;
            this.lvAvsnitt.LabelEdit = true;
            this.lvAvsnitt.Location = new System.Drawing.Point(727, 43);
            this.lvAvsnitt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(565, 350);
            this.lvAvsnitt.TabIndex = 25;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.View = System.Windows.Forms.View.Details;
            this.lvAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lvAvsnitt_SelectedIndexChanged);
            // 
            // colAvsnittNr
            // 
            this.colAvsnittNr.Text = "#";
            this.colAvsnittNr.Width = 25;
            // 
            // colAvsnittTitel
            // 
            this.colAvsnittTitel.Text = "Titel";
            this.colAvsnittTitel.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kategoriadmin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Namn:";
            // 
            // txtPodcastName
            // 
            this.txtPodcastName.Location = new System.Drawing.Point(447, 43);
            this.txtPodcastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPodcastName.Name = "txtPodcastName";
            this.txtPodcastName.Size = new System.Drawing.Size(132, 22);
            this.txtPodcastName.TabIndex = 39;
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.Location = new System.Drawing.Point(35, 53);
            this.txtNyKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(199, 22);
            this.txtNyKategori.TabIndex = 38;
            this.txtNyKategori.TextChanged += new System.EventHandler(this.txtNyKategori_TextChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(755, 23);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 17);
            this.lblKategori.TabIndex = 37;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblIntervall
            // 
            this.lblIntervall.AutoSize = true;
            this.lblIntervall.Location = new System.Drawing.Point(588, 23);
            this.lblIntervall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntervall.Name = "lblIntervall";
            this.lblIntervall.Size = new System.Drawing.Size(61, 17);
            this.lblIntervall.TabIndex = 36;
            this.lblIntervall.Text = "Intervall:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(25, 23);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblURL.Size = new System.Drawing.Size(40, 17);
            this.lblURL.TabIndex = 35;
            this.lblURL.Text = "URL:";
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(287, 48);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(36, 28);
            this.btnTaBortKategori.TabIndex = 34;
            this.btnTaBortKategori.Text = "✖";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillKategori.Location = new System.Drawing.Point(243, 48);
            this.btnLaggTillKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(36, 28);
            this.btnLaggTillKategori.TabIndex = 33;
            this.btnLaggTillKategori.Text = "➕";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // btnAndraNamnKategori
            // 
            this.btnAndraNamnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndraNamnKategori.Location = new System.Drawing.Point(335, 49);
            this.btnAndraNamnKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAndraNamnKategori.Name = "btnAndraNamnKategori";
            this.btnAndraNamnKategori.Size = new System.Drawing.Size(36, 28);
            this.btnAndraNamnKategori.TabIndex = 32;
            this.btnAndraNamnKategori.Text = "/";
            this.btnAndraNamnKategori.UseVisualStyleBackColor = true;
            this.btnAndraNamnKategori.Click += new System.EventHandler(this.btnAndraNamnKategori_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTaBort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort.Location = new System.Drawing.Point(364, 177);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(129, 117);
            this.btnTaBort.TabIndex = 31;
            this.btnTaBort.Text = "❌";
            this.btnTaBort.UseVisualStyleBackColor = false;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnUppdateraFeed
            // 
            this.btnUppdateraFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUppdateraFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUppdateraFeed.Location = new System.Drawing.Point(1120, 32);
            this.btnUppdateraFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUppdateraFeed.Name = "btnUppdateraFeed";
            this.btnUppdateraFeed.Size = new System.Drawing.Size(49, 46);
            this.btnUppdateraFeed.TabIndex = 30;
            this.btnUppdateraFeed.Text = "❤";
            this.btnUppdateraFeed.UseVisualStyleBackColor = false;
            this.btnUppdateraFeed.Click += new System.EventHandler(this.btnUppdateraFeed_Click);
            // 
            // btnLaggTillURL
            // 
            this.btnLaggTillURL.BackColor = System.Drawing.Color.Lime;
            this.btnLaggTillURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillURL.Location = new System.Drawing.Point(1003, 32);
            this.btnLaggTillURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaggTillURL.Name = "btnLaggTillURL";
            this.btnLaggTillURL.Size = new System.Drawing.Size(52, 44);
            this.btnLaggTillURL.TabIndex = 29;
            this.btnLaggTillURL.Text = "➕";
            this.btnLaggTillURL.UseVisualStyleBackColor = false;
            this.btnLaggTillURL.Click += new System.EventHandler(this.btnLaggTillURL_Click);
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(29, 43);
            this.txtRSSURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(383, 22);
            this.txtRSSURL.TabIndex = 28;
            this.txtRSSURL.Text = "https://www.svt.se/nyheter/rss.xml";
            this.txtRSSURL.TextChanged += new System.EventHandler(this.txtRSSURL_TextChanged);
            // 
            // cmbUppdateringsIntervall
            // 
            this.cmbUppdateringsIntervall.FormattingEnabled = true;
            this.cmbUppdateringsIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbUppdateringsIntervall.Location = new System.Drawing.Point(592, 43);
            this.cmbUppdateringsIntervall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUppdateringsIntervall.Name = "cmbUppdateringsIntervall";
            this.cmbUppdateringsIntervall.Size = new System.Drawing.Size(157, 24);
            this.cmbUppdateringsIntervall.TabIndex = 27;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(759, 43);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(235, 24);
            this.cmbKategori.Sorted = true;
            this.cmbKategori.TabIndex = 26;
            // 
            // tabReader
            // 
            this.tabReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReader.Controls.Add(this.tabPageNewsReader);
            this.tabReader.Controls.Add(this.tabPageNewsManager);
            this.tabReader.Controls.Add(this.tabPageKategoriManager);
            this.tabReader.Location = new System.Drawing.Point(16, 15);
            this.tabReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReader.Name = "tabReader";
            this.tabReader.SelectedIndex = 0;
            this.tabReader.Size = new System.Drawing.Size(1312, 784);
            this.tabReader.TabIndex = 43;
            // 
            // tabPageNewsReader
            // 
            this.tabPageNewsReader.Controls.Add(this.label4);
            this.tabPageNewsReader.Controls.Add(this.lbxNewsReaderKategori);
            this.tabPageNewsReader.Controls.Add(this.lblTitelDescription);
            this.tabPageNewsReader.Controls.Add(this.txtDescription);
            this.tabPageNewsReader.Controls.Add(this.lvAvsnitt);
            this.tabPageNewsReader.Controls.Add(this.lblAvsnitt);
            this.tabPageNewsReader.Controls.Add(this.label2);
            this.tabPageNewsReader.Controls.Add(this.lvFeed);
            this.tabPageNewsReader.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewsReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNewsReader.Name = "tabPageNewsReader";
            this.tabPageNewsReader.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNewsReader.Size = new System.Drawing.Size(1304, 755);
            this.tabPageNewsReader.TabIndex = 0;
            this.tabPageNewsReader.Text = "News Reader";
            this.tabPageNewsReader.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kategorier:";
            // 
            // lbxNewsReaderKategori
            // 
            this.lbxNewsReaderKategori.FormattingEnabled = true;
            this.lbxNewsReaderKategori.ItemHeight = 16;
            this.lbxNewsReaderKategori.Items.AddRange(new object[] {
            "TestKategori1",
            "TestKategori2",
            "TestKategori3"});
            this.lbxNewsReaderKategori.Location = new System.Drawing.Point(8, 43);
            this.lbxNewsReaderKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxNewsReaderKategori.Name = "lbxNewsReaderKategori";
            this.lbxNewsReaderKategori.Size = new System.Drawing.Size(152, 340);
            this.lbxNewsReaderKategori.TabIndex = 27;
            this.lbxNewsReaderKategori.SelectedIndexChanged += new System.EventHandler(this.lbxNewsReaderKategori_SelectedIndexChanged);
            // 
            // tabPageNewsManager
            // 
            this.tabPageNewsManager.Controls.Add(this.lbxPodcastNamesToDelete);
            this.tabPageNewsManager.Controls.Add(this.label5);
            this.tabPageNewsManager.Controls.Add(this.txtRSSURL);
            this.tabPageNewsManager.Controls.Add(this.txtPodcastName);
            this.tabPageNewsManager.Controls.Add(this.cmbKategori);
            this.tabPageNewsManager.Controls.Add(this.cmbUppdateringsIntervall);
            this.tabPageNewsManager.Controls.Add(this.lblURL);
            this.tabPageNewsManager.Controls.Add(this.btnLaggTillURL);
            this.tabPageNewsManager.Controls.Add(this.btnTaBort);
            this.tabPageNewsManager.Controls.Add(this.label3);
            this.tabPageNewsManager.Controls.Add(this.lblIntervall);
            this.tabPageNewsManager.Controls.Add(this.lblKategori);
            this.tabPageNewsManager.Controls.Add(this.btnUppdateraFeed);
            this.tabPageNewsManager.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewsManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageNewsManager.Name = "tabPageNewsManager";
            this.tabPageNewsManager.Size = new System.Drawing.Size(1304, 755);
            this.tabPageNewsManager.TabIndex = 2;
            this.tabPageNewsManager.Text = "News Manager";
            this.tabPageNewsManager.UseVisualStyleBackColor = true;
            this.tabPageNewsManager.Enter += new System.EventHandler(this.tabPageNewsManager_Enter);
            // 
            // lbxPodcastNamesToDelete
            // 
            this.lbxPodcastNamesToDelete.FormattingEnabled = true;
            this.lbxPodcastNamesToDelete.ItemHeight = 16;
            this.lbxPodcastNamesToDelete.Location = new System.Drawing.Point(29, 177);
            this.lbxPodcastNamesToDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxPodcastNamesToDelete.Name = "lbxPodcastNamesToDelete";
            this.lbxPodcastNamesToDelete.Size = new System.Drawing.Size(325, 116);
            this.lbxPodcastNamesToDelete.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ta bort feed";
            // 
            // tabPageKategoriManager
            // 
            this.tabPageKategoriManager.Controls.Add(this.label1);
            this.tabPageKategoriManager.Controls.Add(this.txtNyKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnTaBortKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnLaggTillKategori);
            this.tabPageKategoriManager.Controls.Add(this.lbxKategorier);
            this.tabPageKategoriManager.Controls.Add(this.lblNyKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnAndraNamnKategori);
            this.tabPageKategoriManager.Location = new System.Drawing.Point(4, 25);
            this.tabPageKategoriManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageKategoriManager.Name = "tabPageKategoriManager";
            this.tabPageKategoriManager.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageKategoriManager.Size = new System.Drawing.Size(1304, 755);
            this.tabPageKategoriManager.TabIndex = 1;
            this.tabPageKategoriManager.Text = "Kategori manager";
            this.tabPageKategoriManager.UseVisualStyleBackColor = true;
            // 
            // FrmAvsnitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 814);
            this.Controls.Add(this.tabReader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAvsnitt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Really Simple Syndication by Grupp 28 ";
            this.Load += new System.EventHandler(this.FrmAvsnitt_Load);
            this.tabReader.ResumeLayout(false);
            this.tabPageNewsReader.ResumeLayout(false);
            this.tabPageNewsReader.PerformLayout();
            this.tabPageNewsManager.ResumeLayout(false);
            this.tabPageNewsManager.PerformLayout();
            this.tabPageKategoriManager.ResumeLayout(false);
            this.tabPageKategoriManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKategorier;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListView lvFeed;
        private System.Windows.Forms.ColumnHeader colFeedAvsnitt;
        private System.Windows.Forms.ColumnHeader colFeedNamn;
        private System.Windows.Forms.ColumnHeader colFeedIntervall;
        private System.Windows.Forms.ColumnHeader colFeedKategori;
        private System.Windows.Forms.Label lblTitelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.ColumnHeader colAvsnittNr;
        private System.Windows.Forms.ColumnHeader colAvsnittTitel;
        private System.Windows.Forms.ColumnHeader colFeedSenastUppdaterad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPodcastName;
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblIntervall;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnAndraNamnKategori;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnUppdateraFeed;
        private System.Windows.Forms.Button btnLaggTillURL;
        private System.Windows.Forms.TextBox txtRSSURL;
        private System.Windows.Forms.ComboBox cmbUppdateringsIntervall;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TabControl tabReader;
        private System.Windows.Forms.TabPage tabPageNewsReader;
        private System.Windows.Forms.TabPage tabPageKategoriManager;
        private System.Windows.Forms.TabPage tabPageNewsManager;
        private System.Windows.Forms.ListBox lbxNewsReaderKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxPodcastNamesToDelete;
    }
}

