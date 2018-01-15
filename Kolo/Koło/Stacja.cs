using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koło
{
    public class Stacja : ICloneable
    {

        private string nazwaStacji;
        private bool oplataKlimatyczna;
        
        public void utworzstacje(string nazwaStacji, bool oplataKlimatyczna)
        {
            this.nazwaStacji = nazwaStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;

        }


        public override string ToString()
        {
            return "Stacja: " + nazwaStacji + ",oplata klimatyczna: " + oplataKlimatyczna;
        }
        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
  
}