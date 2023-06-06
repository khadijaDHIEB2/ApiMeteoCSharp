using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagApi
{
    public interface ITag
    {
        List<Tram> GetTrams();
    }
}
