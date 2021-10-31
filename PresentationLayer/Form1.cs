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
using System.Diagnostics;
using DataAccesLayer;

namespace Grupp_28_RSS
{

    public partial class FrmAvsnitt : Form
    {

        private string valdKategori;
        private string valdPodcast;

        private string valdPodcastNamn;
        private string valdPodcastKategori;
        private int valdPodcastIntervall;
        private bool Timerboolean = true;
        KategoriService kategoriService;
        //AvsnittService avsnittService;
        private PodcastService podcastService;
        private static Validering validator = new Validering();
        private Timer timer;
        private readonly List<List<Podcast>> lista = new List<List<Podcast>>();
        private readonly List<Podcast> Interval1 = new List<Podcast>();
        private readonly List<Podcast> Interval2 = new List<Podcast>();
        private readonly List<Podcast> Interval3 = new List<Podcast>();
        private readonly int[] intervalNumbers = new int[] { 0, 1, 2 };
        public FrmAvsnitt()
        {
            InitializeComponent();
            valdKategori = null;
            kategoriService = new KategoriService();
            //avsnittService = new AvsnittService();
            podcastService = new PodcastService();
            validator = new Validering();
            PodcastTimer();

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

            lvFeed.BeginUpdate();

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
            lvFeed.EndUpdate();
            lvFeed.Refresh();


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

            if (valdKategori != null)
            {
                kategoriService.RenameKategori(valdKategori, txtNyKategori.Text);
                //string nyNamn = txtNyKategori.Text;
                //kategoriService.RenameKategori();
                ClearAndReloadKategorieListAfterChange();
            }

        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            if (txtNyKategori.Text != valdKategori && validator.CheckIfCategoryIsAvailable(txtNyKategori))
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
            podcastService.ChangePodcast(valdPodcastNamn, txtPodcastName.Text, valdPodcastIntervall, cmbUppdateringsIntervall.SelectedIndex, valdPodcastKategori, cmbKategori.SelectedItem.ToString());


            ClearAndReloadPodcastsListAfterChange();
        }

        private void lvFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sätter några fält till värden som är lagrade om använderaren skulle vilja ändra i feed.

            //Gör något bara om något är valt. Ananrs blir det null error utan ifsatsen.
            if (lvFeed.SelectedItems.Count > 0)
            {

                var item = lvFeed.SelectedItems[0];

                valdPodcast = item.SubItems[1].Text;

                //Sätter alla fält till vald podcast för ändring
                txtPodcastName.Text = item.SubItems[1].Text;
                valdPodcastNamn = item.SubItems[1].Text;

                cmbUppdateringsIntervall.SelectedIndex = Convert.ToInt32(item.SubItems[2].Text);
                valdPodcastIntervall = cmbUppdateringsIntervall.SelectedIndex;

                cmbKategori.SelectedIndex = kategoriService.GetKategoriIndex(item.SubItems[3].Text);
                valdPodcastKategori = cmbKategori.Text;


                txtPodcastName.Text = item.SubItems[1].Text;
                //valdPodcast = lvFeed.Items[1].Text;


            }
        }

        private void PodcastTimer()
        {
            List<Podcast> podcast = podcastService.GetAllPodcasts();
            int uppdateFrequency = 0;
            foreach (Podcast podcasts in podcast)
            {
                switch (podcasts.UppdateringsIntervall)
                {
                    case 0:
                        Interval1.Add(podcasts);
                        break;
                    case 1:
                        Interval2.Add(podcasts);
                        break;
                    case 2:
                        Interval3.Add(podcasts);
                        break;
                }
            }
            lista.Add(Interval1);
            lista.Add(Interval2);
            lista.Add(Interval3);

            for (int i = 0; i < lista.Count; i++)
            {
                switch (i + 1)
                {
                    case 0:
                        uppdateFrequency = 60000;
                        break;
                    case 1:
                        uppdateFrequency = 300000;
                        break;
                    case 2:
                        uppdateFrequency = 600000;
                        break;
                }

                timer = new Timer
                {

                    Interval = uppdateFrequency,
                    Enabled = true,
                    Tag = lista[i],
                };

                if (Timerboolean)
                {
                    timer.Tick += new EventHandler(TimeTracker_Tick);
                    timer.Start();
                }
            }

            Timerboolean = false;
        }

        private void TimeTracker_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            List<Podcast> Tuppdate = (List<Podcast>)timer.Tag;

             UppdateraFranTimer(Tuppdate);
        }
        private async void UppdateraFranTimer(List<Podcast> Tuppdate)
        {
            
            var watch = Stopwatch.StartNew();
            

            if (Tuppdate.Count > 0)
            {
                try
                {
                    await podcastService.UpdateAllPodcasts(Tuppdate);
                    watch.Stop();
                    
                }
                catch (Exception)
                {
                    
                }
            }
        }
    }
}

