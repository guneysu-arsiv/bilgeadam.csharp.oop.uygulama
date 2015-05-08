using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.DAL
{
    public partial class All
    {
        public IList<Entity.Kayit> Listele()
        {
            List<Entity.Kayit> kayitlar = new List<Entity.Kayit>();
            foreach (var durum in DB.Ortak.durumlar)
            {
                kayitlar.Add(durum);
            }

            foreach (var resim in DB.Ortak.resimler)
            {
                kayitlar.Add(resim);
            }

            foreach (var yazi in DB.Ortak.yazilar)
            {
                kayitlar.Add(yazi);
            }

            return kayitlar;
        }
    }
}
