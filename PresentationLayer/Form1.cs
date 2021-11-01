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
   //     private string valdPodcast;
        private List<Avsnitt> valdAvsnitt;

        private string valdPodcastNamn;
        private string valdPodcastKategori;
        private int valdPodcastIntervall;



        KategoriService kategoriService;
        AvsnittService avsnittService;
        PodcastService podcastService;


        private static Validering validator = new Validering();
        public FrmAvsnitt()
        {
            InitializeComponent();
            valdKategori = null;
            kategoriService = new KategoriService();
            avsnittService = new AvsnittService();
            podcastService = new PodcastService();
            validator = new Validering();

        }

        private void FrmAvsnitt_Load(object sender, EventArgs e)
        {
            //Lägg in alla kod som ska köras när formen laddar.
            // MessageBox.Show("Welcome to the show");

            //Hämta podcast.url och lägg till dem i en task för async downloader. 
            txtDescription.Text = $"Idag är den {DateTime.Now.ToShortDateString()} och nedan visas alla sparade podcasts:\r\n";
            txtDescription.Text += $"---------------------------------------\r\n";

            foreach (var podcast in podcastService.GetAllPodcasts())
            {
                txtDescription.Text += $"{podcast.URL}\r\n";
            }


            ClearAndReloadKategorieListAfterChange();
            ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
        }

        private void ClearAndReloadPodcastsListAfterChange(List<Podcast> podcast)
        {

            //Uppdatera podcast XML för att ta med senaste ändringar. 
            //UpdatePodcastXMLToLatest();


            lvFeed.BeginUpdate();
            lvFeed.Items.Clear();
            foreach (Podcast item in podcast)
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
            ClearAndReloadPodcastManagerNameList();
        }


        private void ClearAndReloadPodcastManagerNameList()
        {
            var listOfpodcasts = podcastService.GetAllPodcasts();
            
            lbxPodcastToDelete.Items.Clear();
            lbxPodcastToChange.Items.Clear();


            foreach (Podcast pod in listOfpodcasts)
            {
                lbxPodcastToDelete.Items.Add(pod.Namn);
                lbxPodcastToChange.Items.Add(pod.Namn);
            }

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

            lbxNewsReaderKategori.Items.Clear();
            lbxNewsReaderKategori.Items.Add("Visa Alla Nyheter");

            cmbKategori.Text = "";
            cmbKategori.Items.Clear();

            cmbUppdateradKategori.Text = "";
            cmbUppdateradKategori.Items.Clear();

           foreach (Kategori item in kategoriService.GetAllKategoris())
            {
                if (item != null)
                {
                    lbxKategorier.Items.Add(item.KategoriNamn);
                    lbxNewsReaderKategori.Items.Add(item.KategoriNamn);
                    cmbKategori.Items.Add(item.KategoriNamn);
                    cmbUppdateradKategori.Items.Add(item.KategoriNamn);
                
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
              ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
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
            
            DialogResult dialogResult = MessageBox.Show("Vill du ta bort kategori och alla podcast inom?", "Kategori manager", MessageBoxButtons.YesNo);
         
                if (lbxKategorier.SelectedItem != null && dialogResult == DialogResult.Yes)
            {

                podcastService.DeletePodcastByKategori(lbxKategorier.SelectedItem.ToString());

                kategoriService.DeleteKategori(lbxKategorier.SelectedItem.ToString());
                txtNyKategori.Text = null;
                ClearAndReloadKategorieListAfterChange();
                ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
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

        private void ShowOnlySelectedFeedsByKategori(string kategori)
        {
            var listOfPodcasts = podcastService.GetAllPodcasts();
            List<Podcast> kategoriPoddar;

            if (lbxNewsReaderKategori.SelectedIndex == 0)
            {
                kategoriPoddar = listOfPodcasts;
            }
            else
            {
                kategoriPoddar = (from pod in listOfPodcasts
                                                where pod.kategori == kategori
                                                select pod).ToList();
            }
            
       

            ClearAndReloadPodcastsListAfterChange(kategoriPoddar);
        }

        private async void btnLaggTillURL_Click(object sender, EventArgs e)
        {

            //IF sats för att kolla om namn som läggs till inte är en dubblett. 
            //Valt att använda ASYNC när vi lägger till en podcast ifall det skulle vara en stor podcast som "hänger" programmet. 

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of b34f79b (Update Form1.cs)
            if (txtRSSURL.Text != "" && txtPodcastName != null && cmbIntervall.SelectedIndex != -1 && cmbKategori.SelectedIndex != -1)
            {
                await podcastService.DownloadPodcastAsync(txtRSSURL.Text.ToString(), txtPodcastName.Text.ToString(), cmbKategori.SelectedItem.ToString(), Convert.ToInt32(cmbIntervall.SelectedIndex));
                ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
            }
            else
            {
                 
                btnLaggTillURL.BackColor = Color.Red;
            }




            btnLaggTillURL.Enabled = false;
           // btnLaggTillURL.BackColor = Color.LightGray;
<<<<<<< HEAD
=======
=======
            await podcastService.DownloadPodcastAsync(txtRSSURL.Text.ToString(), txtPodcastName.Text.ToString(), cmbKategori.SelectedItem.ToString(), Convert.ToInt32(cmbUppdateringsIntervall.SelectedIndex));
            ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());



>>>>>>> parent of 4737a70 (Merge branch 'master' into PayamKatt)
>>>>>>> parent of b34f79b (Update Form1.cs)
        }

private void ClearNewsTextAfterChange()
        {
            txtDescription.Text = "";
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (lvFeed.SelectedItems != null)
            {
                podcastService.DeletPodcast(lbxPodcastToDelete.SelectedItem.ToString());
                ClearAndReloadKategorieListAfterChange();
            }
            ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
            ClearNewsTextAfterChange();
        }

        private void btnUppdateraFeed_Click(object sender, EventArgs e)
        {
            podcastService.ChangePodcast(valdPodcastNamn, txtUppdateradPodcastNamn.Text, valdPodcastIntervall, cmbUppdateradIntervall.SelectedIndex, valdPodcastKategori, cmbUppdateradKategori.SelectedItem.ToString());

<<<<<<< HEAD

            ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
            btnUppdateraFeed.Enabled = false;
            btnUppdateraFeed.BackColor = Color.LightGray;
=======
            ClearAndReloadPodcastsListAfterChange(podcastService.GetAllPodcasts());
            btnUppdateraFeed.Enabled = false;
<<<<<<< HEAD
            btnUppdateraFeed.BackColor = Color.LightGray;
=======
>>>>>>> parent of 4737a70 (Merge branch 'master' into PayamKatt)
>>>>>>> parent of b34f79b (Update Form1.cs)
        }

        private void lvFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            //Sätter några fält till värden som är lagrade om använderaren skulle vilja ändra i feed.
            if (lvFeed.SelectedItems.Count > 0)
            {
            
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

        private void FeedFormControllUpdater(ListBox item)
        {

                       
            btnUppdateraFeed.Enabled = true;
            btnUppdateraFeed.BackColor = Color.GreenYellow;
            
                //Sätter alla fält till vald podcast för ändring
                txtUppdateradPodcastNamn.Text = item.SelectedItem.ToString();

            //Loopia ingeom alla podcast för att hitta den rätta. 
            //Använder en LINQ för att det är så vacker och lätt att arbeta med.
            var podcast = from pod in podcastService.GetAllPodcasts()
                          where pod.Namn == txtUppdateradPodcastNamn.Text
                          select pod;

            //Använder Foreach för att jag vet inte hur jag ska kunna sätta fler värden med linq.
            foreach (var valdPod in podcast)
            {
                cmbUppdateradKategori.SelectedItem = valdPod.kategori;
                cmbUppdateradIntervall.SelectedIndex = valdPod.UppdateringsIntervall;
            }

            //Fortsätter ange värden till olika text fält
            valdPodcastNamn = txtUppdateradPodcastNamn.Text;
            valdPodcastKategori = cmbUppdateradKategori.SelectedItem.ToString();
            valdPodcastIntervall = cmbUppdateradIntervall.SelectedIndex;



        }

        private void lvAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAvsnitt.SelectedItems.Count > 0)
            {
                GetOneAvsnittDescription(lvAvsnitt.SelectedItems[0]);

            }
        }

        private void txtRSSURL_TextChanged(object sender, EventArgs e)
        {
            txtPodcastName.Text = "";
            cmbKategori.SelectedIndex = -1;
            cmbIntervall.SelectedIndex = -1;

            //Enable knappen att lägga till url efter att ha rensat alla fält.
            btnLaggTillURL.Enabled = true;
            btnLaggTillURL.BackColor = Color.GreenYellow;

        }

        private void lbxNewsReaderKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxNewsReaderKategori.SelectedItem !=null)
            {
                string kategori = lbxNewsReaderKategori.SelectedItem.ToString();

                if (kategori != null)
                {
                    ShowOnlySelectedFeedsByKategori(kategori);
                }
            }

      

        }

        private void tabPageNewsManager_Enter(object sender, EventArgs e)
        {


            ClearAndReloadPodcastManagerNameList();

        }

        private void lbxPodcastToChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            FeedFormControllUpdater(lbxPodcastToChange);
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of b34f79b (Update Form1.cs)

        private void tabPageNewsManager_Click(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPodcastToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTaBort.Enabled = true;
            btnTaBort.BackColor = Color.GreenYellow;
        }

        private void GreyAndDisableButtons(object sender, EventArgs e)
        {
            //sender[BackColor = Color.Gray];
        }
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 4737a70 (Merge branch 'master' into PayamKatt)
>>>>>>> parent of b34f79b (Update Form1.cs)
    }
}
