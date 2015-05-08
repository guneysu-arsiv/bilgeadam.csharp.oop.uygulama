using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AjandaUygulama;

namespace AjandaUygulama.UI
{
    public partial class uiDurum : BaseForm
    {
        public uiDurum()
        {
            InitializeComponent();
        }

        private void Durum_Load(object sender, EventArgs e)
        {
            uiInit();
            uiInitEvents();
        }

        private void uiInitEvents()
        {
            btnKaydet.Click += (o, e) =>
            {
                try
                {
                    dal.KaydetDurum(
                        new Entity.Durum
                        {
                            title = txtTitle.Text,
                            id = Convert.ToInt32(txtID.Text),
                            durum = (Enums.Durum)cmbDurum.SelectedItem,
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

        private void uiInit()
        {
            cmbDurum.DataSource = Enum.GetValues(typeof(Enums.Durum));
            txtID.Text = DB.Ortak.durumlar.Count().ToString();
        }

    }
}
