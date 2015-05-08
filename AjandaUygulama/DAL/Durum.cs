using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Durum> ListeleDurum(DateTime? tarih = null)
        {
            var liste = new List<Entity.Durum>();

            if (tarih == null)
            {
                liste = DB.Ortak.durumlar;
            }
            else
            {
                foreach (var item in DB.Ortak.durumlar)
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

        public void KaydetDurum(Entity.Durum e){

            // BLL
            if (String.IsNullOrEmpty(e.title))
            {
                throw new Exception("Başlık Boş Bırakılamaz");
            }

            e.id = DB.Ortak.durumlar.Count();
            DB.Ortak.durumlar.Add(e);
        }

        public void SilDurum(int id)
        {
            var i = 0;
            foreach (var item in DB.Ortak.durumlar)
            {
                if (item.id == id)
                {
                    DB.Ortak.durumlar.RemoveAt(i);
                }
                i++;
            }
        }
    }
}
