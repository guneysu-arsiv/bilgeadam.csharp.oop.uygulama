using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Resim> ListeleResim(DateTime? tarih = null)
        {
            var liste = new List<Entity.Resim>();
            if (tarih == null)
            {
                liste =  DB.Ortak.resimler;
            }
            else
            {
                foreach (var item in DB.Ortak.resimler)
                {
                    TimeSpan ts = (TimeSpan) (tarih - item.date);
                    int fark = (int)ts.TotalDays;
                    if ( fark == 0  )
                    {
                        liste.Add(item);
                    }
                }
            }
            return liste;
        }

        public void KaydetResim(Entity.Resim e)
        {
            // BLL
            if (String.IsNullOrEmpty(e.title))
            {
                throw new Exception("Başlık Boş Bırakılamaz");
            }
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
