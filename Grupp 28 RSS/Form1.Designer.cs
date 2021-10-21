
namespace Grupp_28_RSS
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvChAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChIntervall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbxKategorier
            // 
            this.lbxKategorier.FormattingEnabled = true;
            this.lbxKategorier.Location = new System.Drawing.Point(593, 51);
            this.lbxKategorier.Name = "lbxKategorier";
            this.lbxKategorier.Size = new System.Drawing.Size(120, 95);
            this.lbxKategorier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategorier:";
            // 
            // lbxAvsnitt
            // 
            this.lbxAvsnitt.FormattingEnabled = true;
            this.lbxAvsnitt.Location = new System.Drawing.Point(102, 257);
            this.lbxAvsnitt.Name = "lbxAvsnitt";
            this.lbxAvsnitt.Size = new System.Drawing.Size(120, 95);
            this.lbxAvsnitt.TabIndex = 2;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(99, 241);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(107, 13);
            this.lblAvsnitt.TabIndex = 3;
            this.lblAvsnitt.Text = "[RSSNamn]  : Avsnitt";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(388, 201);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 4;
            // 
            // cmbUppdateringsIntervall
            // 
            this.cmbUppdateringsIntervall.FormattingEnabled = true;
            this.cmbUppdateringsIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbUppdateringsIntervall.Location = new System.Drawing.Point(261, 201);
            this.cmbUppdateringsIntervall.Name = "cmbUppdateringsIntervall";
            this.cmbUppdateringsIntervall.Size = new System.Drawing.Size(121, 21);
            this.cmbUppdateringsIntervall.TabIndex = 5;
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(102, 201);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(120, 20);
            this.txtRSSURL.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvChAvsnitt,
            this.lvChNamn,
            this.lvChIntervall,
            this.chKategori});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(117, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvChAvsnitt
            // 
            this.lvChAvsnitt.Text = "Avsnitt";
            // 
            // lvChIntervall
            // 
            this.lvChIntervall.Text = "Uppdateringsintervall";
            // 
            // chKategori
            // 
            this.chKategori.Text = "Kategori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtRSSURL);
            this.Controls.Add(this.cmbUppdateringsIntervall);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lbxAvsnitt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxKategorier);
            this.Name = "Form1";
            this.Text = "Really Simple Syndication by Grupp 28 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAvsnitt;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbUppdateringsIntervall;
        private System.Windows.Forms.TextBox txtRSSURL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvChAvsnitt;
        private System.Windows.Forms.ColumnHeader lvChNamn;
        private System.Windows.Forms.ColumnHeader lvChIntervall;
        private System.Windows.Forms.ColumnHeader chKategori;
    }
}

