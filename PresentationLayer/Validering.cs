using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using DataAccessLayer.Repositories;
using modelss;
using ServiceLayer.ServiceFolder;


namespace Grupp_28_RSS
{
    public class Validering

       
    {
        KategoriService kategoriService;

        public Validering()
        {
            kategoriService = new KategoriService();
        }
        public bool StringIsEmpty(string input)
        {
            bool result = false;

            if (input.Equals(""))
            {
                result = true;
            }

            return result;
        }

        public bool ValideraURL(string url)
        {
            string URLValidering = string.Empty;
            try
            {
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                WebClient obj = new WebClient();
                URLValidering = enc.GetString(obj.DownloadData(url));
            }
            catch (Exception e)
            {
                
                return false;
            }
            return URLValidering.Length != 0 ? true : false;
        }

        public bool ComboBoxHasSelectedValue(ComboBox comboBox)
        {
            bool result = true;

            if (!(comboBox.SelectedIndex > -1))
            {
                result = false;
            }

            return result;
        }
        public bool TextBoxNotEmptyOrNull(TextBox textBox)
        {
            bool result = true;

            if (!String.IsNullOrEmpty(textBox.Text))
            {
                result = false;
            }

            return result;
        }


        public bool CheckIfCategoryIsAvailable(TextBox textBox)
        {
            var KategorierSomFinns = kategoriService.GetAllKategoris();

            foreach (var kategori in KategorierSomFinns)
            {
                if (textBox.Text == kategori.ToString())
                {
                    MessageBox.Show("Det finns redan en kategori med det namnet");
                    return false;
                }

            }
            return true;
        }



    }
}
