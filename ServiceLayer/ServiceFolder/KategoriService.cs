using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;
using DataAccessLayer.Repositories;

namespace ServiceLayer.ServiceFolder
{
    public class KategoriService
    {
        IKategoriRepository<Kategori> kategoriRepository;

        public KategoriService()
        {
            kategoriRepository = new KategoriRepository();
        }

        public void CreateKategori(string name)
        {
            Kategori nyKategori = null;
            nyKategori = new Kategori(name);
            kategoriRepository.Create(nyKategori);
        }

        public void DeleteKategori(string name)
        {
            int index = kategoriRepository.GetIndex(name);
            kategoriRepository.Delete(index);
        }

        public void RenameKategori(string name)
        {
            int index = kategoriRepository.GetIndex(name);
            kategoriRepository.RenameKategori(index);
        }
    }
}
