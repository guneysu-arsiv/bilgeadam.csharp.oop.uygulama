using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandaUygulama
{
    public partial class GUI : Form
    {
        public DAL.All dal = new DAL.All();

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            dal.ListeleDurum();
            dal.ListeleDurum(new DateTime());

            dal.KaydetDurum(
                new Entity.Durum
                {
                    date = DateTime.Now,
                    durum = Enum.Durum.Musait,
                    title = "Kırmızı Başlık"
                }
                );

            dal.KaydetResim(
                new Entity.Resim
                {
                    date = DateTime.Now,
                    title = "Resim",
                    picturePath = "C:/foo.png"
                }
                );

            lstAll.DataSource = dal.Listele();

            lstResim.DataSource = DB.Ortak.resimler;
            lstYazi.DataSource = DB.Ortak.yazilar;
            lstDurum.DataSource = DB.Ortak.durumlar;

        }
        ~GUI()
        {
            // TODO: Save to file
            // Or to FORM_CLOSING Event
        }
    }
}
