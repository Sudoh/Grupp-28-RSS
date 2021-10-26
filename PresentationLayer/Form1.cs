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

        KategoriService kategoriService;
        public FrmAvsnitt()
        {
            InitializeComponent();
            kategoriService = new KategoriService();

        }

        private void FrmAvsnitt_Load(object sender, EventArgs e)
        {
            //Lägg in alla kod som ska köras när formen laddar. 
            // MessageBox.Show("Welcome to the show");
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
            //RenameKategori(string name);
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            kategoriService.CreateKategori(txtNyKategori.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            kategoriService.DeleteKategori(lbxKategorier.SelectedItem.ToString());
        }
    }
}
