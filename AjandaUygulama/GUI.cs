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
        public List<Entity.Kayit> kayitlarFiltre = new List<Entity.Kayit>();
        public List<Entity.Durum> durumlarFiltre = new List<Entity.Durum>();
        public List<Entity.Resim> resimlerFiltre = new List<Entity.Resim>();
        public List<Entity.Yazi> yazilarFiltre = new List<Entity.Yazi>();

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
                    durum = Enums.Durum.Musait,
                    title = "Kırmızı Başlık"
                }
                );

            dal.KaydetResim(
                new Entity.Resim(pictures: new string[] { "C:/foo.png"} )
                {
                    date = DateTime.Now,
                    title = "Resim",
                }
                );

            dal.KaydetYazi(
                new Entity.Yazi
                {
                    date = DateTime.Now,
                    title = "Yazı",
                    body = "Açıklama"
                }
                );


            uiInit();
            uiInitEvents();

        }

        private void uiInit()
        {
            lstAll.DataSource = dal.Listele();
            lstDurum.DataSource = DB.Ortak.durumlar;
            lstResim.DataSource = DB.Ortak.resimler;
            lstYazi.DataSource = DB.Ortak.yazilar;

        }
        ~GUI()
        {
            // TODO: Save to file
            // Or to FORM_CLOSING Event
        }

        private void uiRefresh()
        {
            lstAll.DataSource = dal.Listele();
            lstAll.DataSource = dal.Listele();

            lstDurum.DataSource = null;
            lstDurum.DataSource = DB.Ortak.durumlar;

            lstResim.DataSource = null;
            lstResim.DataSource = DB.Ortak.resimler;

            lstYazi.DataSource = null;
            lstYazi.DataSource = DB.Ortak.yazilar;
        }

        public void uiInitEvents()
        {
            btnRefresh.Click += (o, e) =>
            {
                uiRefresh();
            };

            btnDurum.Click += (o, e) =>
            {
                new UI.uiDurum().ShowDialog();
                uiRefresh();
            };

            btnResim.Click += (o, e) =>
            {
                new UI.uiResim().ShowDialog();
                uiRefresh();
            };

            btnYazi.Click += (o, e) =>
            {
                new UI.uiYazi().ShowDialog();
                uiRefresh();
            };

            lstDurum.DoubleClick += (o, e) =>
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    DB.Ortak.durumlar.RemoveAt(lstDurum.SelectedIndex);
                    uiRefresh();
                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                else
                {
                    //...
                }
            };

            lstResim.DoubleClick += (o, e) =>
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    DB.Ortak.resimler.RemoveAt(lstResim.SelectedIndex);
                    uiRefresh();
                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                else
                {
                    //...
                }
            };

            lstYazi.DoubleClick += (o, e) =>
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    DB.Ortak.yazilar.RemoveAt(lstYazi.SelectedIndex);
                    uiRefresh();
                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                else
                {
                    //...
                }
            };

            btnFiltrele.Click += (o, e) =>
            {
                lstAll.DataSource = null;
                lstDurum.DataSource = null;
                lstResim.DataSource = null;
                lstYazi.DataSource = null;


                durumlarFiltre = dal.ListeleDurum(dtpFiltre.Value);
                resimlerFiltre = dal.ListeleResim(dtpFiltre.Value);
                yazilarFiltre = dal.ListeleYazi(dtpFiltre.Value);


                lstAll.DataSource = kayitlarFiltre;
                lstDurum.DataSource = durumlarFiltre;
                lstResim.DataSource = resimlerFiltre;
                lstYazi.DataSource = yazilarFiltre;

                
            };



        }

    }
}
