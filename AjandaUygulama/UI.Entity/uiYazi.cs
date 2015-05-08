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
    public partial class uiYazi : BaseForm
    {
        public uiYazi()
        {
            InitializeComponent();
        }

        private void Yazi_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dal.KaydetYazi(
                new Entity.Yazi()
                {
                    id = Convert.ToInt32(txtID.Text),
                    title = txtTitle.Text,
                    body = txtBody.Text,
                    date = dtpDate.Value
                }
                );
        }
    }
}
