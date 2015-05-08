using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Yazi> ListeleYazi(DateTime? tarih = null)
        {
            if (tarih == null)
            {
                return DB.Ortak.yazilar;
            }
            else
            {
                return new List<Entity.Yazi>();
            }
        }

        public void KaydetYazi(Entity.Yazi e)
        {
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
