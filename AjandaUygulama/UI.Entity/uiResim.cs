using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandaUygulama.UI
{
    public partial class uiResim : BaseForm
    {
        public uiResim()
        {
            InitializeComponent();
        }

        private void uiResim_Load(object sender, EventArgs e)
        {
            txtID.Text = DB.Ortak.resimler.Count().ToString();

            uiInitEvents();
        }
        public void uiInitEvents()
        {
            btnResimEkle.Click += (o, e) =>
            {
                lstPaths.Items.Add(txtPath.Text);
                txtPath.Clear();
            };

            btnKaydet.Click += (o, e) =>
            {
                try
                {
                    dal.KaydetResim(
                        new Entity.Resim(
                            pictures: lstPaths.Items.Cast<String>().ToList())
                        {
                            id = Convert.ToInt32(txtID.Text),
                            title = txtTitle.Text,
                            date = dtpDate.Value
                        });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }
                this.Close();
            };
        }
    }
}
