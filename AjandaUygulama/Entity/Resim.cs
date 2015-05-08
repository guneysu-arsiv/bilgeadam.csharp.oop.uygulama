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
        private List<string> pictures;

        public Resim()
        {

        }
        public Resim(string[] pictures)
        {
            this.pictures = pictures.ToList();
            /*
            foreach (var picture in pictures)
            {
                picturePaths.Add(picture);
            }
            */
        }

        public Resim(List<string> pictures)
        {
            // TODO: Complete member initialization
            this.pictures = pictures;
        }
    }
}
