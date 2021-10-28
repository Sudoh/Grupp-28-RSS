using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelss;
using ServiceLayer.ServiceFolder;

namespace Grupp_28_RSS
{

    public partial class FrmAvsnitt : Form
    {

        private string valdKategori;
        private string valdPodcast;

        KategoriService kategoriService;
        //AvsnittService avsnittService;
        PodcastService podcastService;
        public FrmAvsnitt()
        {
            InitializeComponent();
            valdKategori = null;
            kategoriService = new KategoriService();
            //avsnittService = new AvsnittService();
            podcastService = new PodcastService();

        }
        
        private void FrmAvsnitt_Load(object sender, EventArgs e)
        {
            //Lägg in alla kod som ska köras när formen laddar.
            // MessageBox.Show("Welcome to the show");
            ClearAndReloadKategorieListAfterChange();
            ClearAndReloadPodcastsListAfterChange();
        }

        private void ClearAndReloadPodcastsListAfterChange()
        {
            lvFeed.Items.Clear();
            foreach (Podcast item in podcastService.GetAllPodcasts())
            {
                if (item != null)
                {
                    ListViewItem rad = new ListViewItem(item.AntalAvsnitt.ToString());
                    rad.SubItems.Add(item.Namn.ToString());
                    rad.SubItems.Add(item.UppdateringsIntervall.ToString());
                    rad.SubItems.Add(item.kategori.ToString());
                    lvFeed.Items.Add(rad);

                }
            }
         
        }

        private void ClearAndReloadKategorieListAfterChange()
        {

            lbxKategorier.Items.Clear();
            cmbKategori.Text = "";
            cmbKategori.Items.Clear();
            foreach (Kategori item in kategoriService.GetAllKategoris())
            {
                if (item != null)
                {
                    lbxKategorier.Items.Add(item.KategoriNamn);
                    cmbKategori.Items.Add(item.KategoriNamn);
                }
            }
        }

        private void btnAndraNamnKategori_Click(object sender, EventArgs e)
        {

            if (valdKategori != null && valdKategori != txtNyKategori.Text)
            {
                kategoriService.RenameKategori(valdKategori, txtNyKategori.Text);
                //string nyNamn = txtNyKategori.Text;
                //kategoriService.RenameKategori();
                ClearAndReloadKategorieListAfterChange();
            }

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            if (txtNyKategori.Text != valdKategori)
            {
                kategoriService.CreateKategori(txtNyKategori.Text);
                txtNyKategori.Text = null;
                ClearAndReloadKategorieListAfterChange();
            }

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (lbxKategorier.SelectedItem != null)
            {
                kategoriService.DeleteKategori(lbxKategorier.SelectedItem.ToString());
                txtNyKategori.Text = null;
                ClearAndReloadKategorieListAfterChange();
            }

        }

        private void lbxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gör något bara om något är valt. Ananrs blir det null error utan ifsatsen.
            if (lbxKategorier.SelectedItems.Count > 0)
            {
                txtNyKategori.Text = lbxKategorier.SelectedItem.ToString();
                valdKategori = lbxKategorier.SelectedItem.ToString();
            }


        }

        private void btnLaggTillURL_Click(object sender, EventArgs e)
        {
           
            podcastService.DownloadPodcast(txtRSSURL.Text.ToString(), txtPodcastName.Text.ToString(), cmbKategori.SelectedItem.ToString(), Convert.ToInt32(cmbUppdateringsIntervall.SelectedIndex));
            ClearAndReloadPodcastsListAfterChange();



        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (lvFeed.SelectedItems != null)
            {
                podcastService.DeletPodcast(txtPodcastName.Text);
                ClearAndReloadKategorieListAfterChange();
            }
            ClearAndReloadPodcastsListAfterChange();
        }

        private void btnUppdateraFeed_Click(object sender, EventArgs e)
        {
            ClearAndReloadPodcastsListAfterChange();
        }

        private void lvFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gör något bara om något är valt. Ananrs blir det null error utan ifsatsen.
            if (lvFeed.SelectedItems.Count > 0)
            {
                
                var item = lvFeed.SelectedItems[0];
                txtPodcastName.Text = item.SubItems[1].Text;
                //valdPodcast = lvFeed.Items[1].Text;
            }
        }
    }
}
