using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagApi
{
    public class Display
    {
       public  static String DisplayInfo(List<Tram> list)
        {
            Console.WriteLine("Id:{0}\tName:{1}", list[0].LongName, list[0].ShortName);
            return list[0].LongName;
        }
    }
}
