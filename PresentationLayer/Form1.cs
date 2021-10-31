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
        private List<Avsnitt> valdAvsnitt;

        private string valdPodcastNamn;
        private int valdPodcastKategori;
        private int valdPodcastIntervall;
        private bool Timerboolean = true;
        KategoriService kategoriService;

        //AvsnittService avsnittService;
        private PodcastService podcastService;

        AvsnittService avsnittService;




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
            avsnittService = new AvsnittService();
            podcastService = new PodcastService();
            validator = new Validering();
            PodcastTimer();

        }

        private void FrmAvsnitt_Load(object sender, EventArgs e)
        {
            //Lägg in alla kod som ska köras när formen laddar.
            // MessageBox.Show("Welcome to the show");

            //Hämta podcast.url och lägg till dem i en task för async downloader. 
            foreach (var podcast in podcastService.GetAllPodcasts())
            {
                txtDescription.Text += $"Url: {podcast.URL} med uppdateringsfrekvens {podcast.UppdateringsIntervall}\r\n";
            }


            ClearAndReloadKategorieListAfterChange();
            ClearAndReloadPodcastsListAfterChange();
        }

        private void ClearAndReloadPodcastsListAfterChange()
        {

            //Uppdatera podcast XML för att ta med senaste ändringar. 
            //UpdatePodcastXMLToLatest();


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
                    rad.SubItems.Add(item.datumTillaggd.ToString());
                    lvFeed.Items.Add(rad);

                }
            }
            lvFeed.EndUpdate();
            lvFeed.Refresh();

            ClearAvsnittList();
        }



        private void UpdatePodcastXMLToLatest()
        {

            //Om podcast behöver uppdateras. Tid senast uppdaterad - tid nu >= intervall.
            if (true)
            {
                for (int i = 0; i < lvFeed.Items.Count; i++)
                {


                }
            }

        }

        private void ClearAvsnittList()
        {
            lvAvsnitt.Items.Clear();
            //lvAvsnitt.Refresh();
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
                podcastService.UpdatePodcasts(valdKategori, txtNyKategori.Text);
                //string nyNamn = txtNyKategori.Text;
                //kategoriService.RenameKategori();
                ClearAndReloadKategorieListAfterChange();
                ClearAndReloadPodcastsListAfterChange();
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

        private async void btnLaggTillURL_Click(object sender, EventArgs e)
        {

            //IF sats för att kolla om namn som läggs till inte är en dubblett. 
            //Valt att använda ASYNC när vi lägger till en podcast ifall det skulle vara en stor podcast som "hänger" programmet. 

            await podcastService.DownloadPodcastAsync(txtRSSURL.Text.ToString(), txtPodcastName.Text.ToString(), cmbKategori.SelectedItem.ToString(), Convert.ToInt32(cmbUppdateringsIntervall.SelectedIndex));
            ClearAndReloadPodcastsListAfterChange();



        }

        private void ClearNewsTextAfterChange()
        {
            txtDescription.Text = "";
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (lvFeed.SelectedItems != null)
            {
                podcastService.DeletPodcast(txtPodcastName.Text);
                ClearAndReloadKategorieListAfterChange();
            }
            ClearAndReloadPodcastsListAfterChange();
            ClearNewsTextAfterChange();
        }

        private void btnUppdateraFeed_Click(object sender, EventArgs e)
        {
            podcastService.ChangePodcast(valdPodcastNamn, txtPodcastName.Text, valdPodcastIntervall, cmbUppdateringsIntervall.SelectedIndex, lvFeed.SelectedItems[0].SubItems[3].Text, cmbKategori.SelectedItem.ToString());


            ClearAndReloadPodcastsListAfterChange();
        }

        private void lvFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tar bort möjlighetne att lägga till url för att slippa dubblett. 
            btnLaggTillURL.Enabled = false;
            btnLaggTillURL.Visible = false;


            //Sätter några fält till värden som är lagrade om använderaren skulle vilja ändra i feed.
            if (lvFeed.SelectedItems.Count > 0)
            {
                FeedFormControllUpdater(lvFeed.SelectedItems[0]);
                SendSelectedFeedToAvsnittHandler(lvFeed.SelectedItems[0]);
                ClearNewsTextAfterChange();
            }


        }

        private void SendSelectedFeedToAvsnittHandler(ListViewItem item)
        {

            valdAvsnitt = podcastService.GetAllAvsnittFromPodcastByName(item.SubItems[1].Text);


            lvAvsnitt.BeginUpdate();
            lvAvsnitt.Items.Clear();

            int i = 1;
            foreach (var a in valdAvsnitt)
            {

                ListViewItem rad = new ListViewItem(i.ToString());
                rad.SubItems.Add(a.NewsTitel.ToString());
                lvAvsnitt.Items.Add(rad);
                i++;
            }

            lvAvsnitt.EndUpdate();
            lvAvsnitt.Refresh();

        }

        public void GetOneAvsnittDescription(ListViewItem item)
        {

            string titel = item.SubItems[1].Text;



            var nyhet = from n in valdAvsnitt
                        where n.NewsTitel == titel
                        select n.NewsDescription.ToString();


            txtDescription.Text = nyhet.FirstOrDefault();
        }

        private void FeedFormControllUpdater(ListViewItem item)
        {


            //Gör något bara om något är valt. Ananrs blir det null error utan ifsatsen.


            valdPodcast = item.SubItems[1].Text;

            //Sätter alla fält till vald podcast för ändring
            txtPodcastName.Text = item.SubItems[1].Text;
            valdPodcastNamn = item.SubItems[1].Text;

            cmbUppdateringsIntervall.SelectedIndex = Convert.ToInt32(item.SubItems[2].Text);
            valdPodcastIntervall = cmbUppdateringsIntervall.SelectedIndex;

            cmbKategori.SelectedIndex = kategoriService.GetKategoriIndex(item.SubItems[3].Text);
            valdPodcastKategori = cmbKategori.SelectedIndex;


            txtPodcastName.Text = item.SubItems[1].Text;



        }

        private void lvAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAvsnitt.SelectedItems.Count > 0)
            {
                GetOneAvsnittDescription(lvAvsnitt.SelectedItems[0]);

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

            private void txtRSSURL_TextChanged(object sender, EventArgs e)
            {
                txtPodcastName.Text = "";
                cmbKategori.SelectedIndex = -1;
                cmbUppdateringsIntervall.SelectedIndex = -1;

                //Enable knappen att lägga till url efter att ha rensat alla fält.
                btnLaggTillURL.Enabled = true;
                btnLaggTillURL.Visible = true;

            }
        
    } }

