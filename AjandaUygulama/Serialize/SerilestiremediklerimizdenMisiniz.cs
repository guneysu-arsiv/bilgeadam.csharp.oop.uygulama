using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace AjandaUygulama.Serialize
{
    [Serializable]
    public class SerilestiremediklerimizdenMisiniz
    {
        public List<Entity.Yazi> y = DB.Ortak.yazilar;
        public List<Entity.Resim> r = DB.Ortak.resimler;
        public List<Entity.Durum> d = DB.Ortak.durumlar;

        public SerilestiremediklerimizdenMisiniz()
        {
            y = DB.Ortak.yazilar;
            r = DB.Ortak.resimler;
            d = DB.Ortak.durumlar;
        }

        public void bas()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(
                "db.bin",
                FileMode.Create,
                FileAccess.Write,
                FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public void cek()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream("db.bin",
                 FileMode.Open, FileAccess.Read, FileShare.Read);
                SerilestiremediklerimizdenMisiniz obj = (SerilestiremediklerimizdenMisiniz)formatter.Deserialize(stream);
                stream.Close();

                DB.Ortak.durumlar = obj.d;
                DB.Ortak.resimler = obj.r;
                DB.Ortak.yazilar = obj.y;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
