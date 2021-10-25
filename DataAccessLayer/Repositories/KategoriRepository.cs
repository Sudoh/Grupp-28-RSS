using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelss;

namespace DataAccessLayer.Repositories
{
    class KategoriRepository : IRepository<Kategori>
    {
        //Note to self: Här sker filhanteringen.
        //Gör om metoderna så att det ser ut soma tt den har laddat från interface när allt är klart. 
        public void Create(Kategori entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Kategori entity)
        {
            throw new NotImplementedException();
        }
    }

}
