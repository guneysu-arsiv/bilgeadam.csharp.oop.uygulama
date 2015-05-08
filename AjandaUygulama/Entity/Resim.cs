using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.Entity
{
    public class Resim:Kayit
    {
        public List<string> picturePaths = new List<string>();

        public Resim()
        {

        }
        public Resim(string[] pictures)
        {
            foreach (var picture in pictures)
            {
                picturePaths.Add(picture);
            }
        }
    }
}
