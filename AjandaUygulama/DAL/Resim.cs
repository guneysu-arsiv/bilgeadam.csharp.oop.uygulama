using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Resim> ListeleResim()
        {
            return DB.Ortak.resimler;
        }

        public void KaydetResim(Entity.Resim e)
        {
            e.id = DB.Ortak.resimler.Count();
            DB.Ortak.resimler.Add(e);
        }

        public void SilResim(int id)
        {
            var i = 0;
            foreach (var item in DB.Ortak.resimler)
            {
                if (item.id == id)
                {
                    DB.Ortak.resimler.RemoveAt(i);
                }
                i++;
            }
        }
    }
}
