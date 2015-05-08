using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Durum> ListeleDurum()
        {
            return DB.Ortak.durumlar;
        }

        public void KaydetDurum(Entity.Durum e){
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
