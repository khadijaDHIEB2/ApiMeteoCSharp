using System;

namespace TagApi
{
    public class Tram
    {
        public string ShortName
        { get; set; }

        public string LongName
        { get; set; }

        public Tram (string shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;
        }


    }
}