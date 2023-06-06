using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagApi;

namespace ApiTests
{
    internal class FakeApiCall : ITag
    {
        public List<Tram> GetTrams()
        {
            List<Tram> list = new List<Tram>
            {
                new Tram("A", "FONTAINE La Poya / PONT DE CLAIX  L'Etoile")
            };
            return list;
        }
    }
}
