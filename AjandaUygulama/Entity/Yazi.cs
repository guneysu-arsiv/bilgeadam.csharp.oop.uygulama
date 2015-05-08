using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.Entity
{
    [Serializable]
    public class Yazi:Kayit
    {
        public string body { get; set; }
    }
}
