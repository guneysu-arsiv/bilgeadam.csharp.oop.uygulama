using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.Entity
{
    [Serializable]
    public abstract class Kayit
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public override string ToString()
        {
            return String.Format("{0} {1}", title, date.ToString());
        }
    }
    
}
