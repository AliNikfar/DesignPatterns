using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    public sealed  class SiteSetting
    {
        public string SiteName { get; set; }
        public string FooterText { get; set; }
        private SiteSetting()
        {

        }
        private static readonly SiteSetting _instance = new SiteSetting();
        public static SiteSetting Instance
        {
        get { 

                return _instance; 
            }
        }
        //public static int _count;
    }
}
