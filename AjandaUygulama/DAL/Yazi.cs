using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public List<Entity.Yazi> ListeleYazi(DateTime? tarih = null)
        {
            var liste = new List<Entity.Yazi>();

            if (tarih == null)
            {
                liste = DB.Ortak.yazilar;
            }
            else
            {
                foreach (var item in DB.Ortak.yazilar)
                {
                    TimeSpan ts = (TimeSpan)(tarih - item.date);
                    int fark = (int)ts.TotalDays;
                    if (fark == 0)
                    {
                        liste.Add(item);
                    }
                }
            }
            return liste;
        }

        public void KaydetYazi(Entity.Yazi e)
        {
            // BLL
            if (String.IsNullOrEmpty(e.title))
            {
                throw new Exception("Başlık Boş Bırakılamaz");
            }
            e.id = DB.Ortak.yazilar.Count();
            DB.Ortak.yazilar.Add(e);
        }

        public void SilYazi(int id)
        {
            var i = 0;
            foreach (var item in DB.Ortak.yazilar)
            {
                if (item.id == id)
                {
                    DB.Ortak.yazilar.RemoveAt(i);
                }
                i++;
            }
        }
    }
}
