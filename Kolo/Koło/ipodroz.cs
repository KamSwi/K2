using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koło
{
    interface ipodroz
    {
        void DodajStacje(string nazwaStacji, bool oplataKlimatyczna);
        void Powrot();
        void UsunStacje();
        void ZapiszPodroz();
    }
}
