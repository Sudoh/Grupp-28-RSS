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

        KategoriService kategoriService;
        AvsnittService avsnittService;
        public FrmAvsnitt()
        {
            InitializeComponent();
            valdKategori = null;
            kategoriService = new KategoriService();
            avsnittService = new AvsnittService();

        }

        private void FrmAvsnitt_Load(object sender, EventArgs e)
        {
            //Lägg in alla kod som ska köras när formen laddar.
            // MessageBox.Show("Welcome to the show");
            ClearAndReloadKategorieListAfterChange();
        }

        private void ClearAndReloadKategorieListAfterChange()
        {

            lbxKategorier.Items.Clear();
            foreach (Kategori item in kategoriService.GetAllKategoris())
            {
                if (item != null)
                {
                    lbxKategorier.Items.Add(item.KategoriNamn);
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
        //private void ListPodDescription(object sender, EventArgs e)
        //{
        //    if (lbxAvsnitt.SelectedItems.Count > 0)
        //    {
        //        txtDescription.Text = PodcastHandler.updateEpisodeDetails(lbxAvsnitt, podcastListview);
        //    }
        //}
    }
}
