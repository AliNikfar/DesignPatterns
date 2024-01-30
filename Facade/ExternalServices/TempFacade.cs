using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ExternalServices
{
    public  class TempFacade
    {
        public int GetTemp(string postalCode)
        {
            var zoneFinder = new ZoneFinder();
            var zone = zoneFinder.GetZone(postalCode);
            var tempratureService = new TempratureService();
            var temprature = tempratureService.GetTemp(zone);
            var tempConvertor = new TempConvertor();
            var ZoneTemprature = tempConvertor.GetCelsius(temprature);
            return ZoneTemprature;

        }
    }
}
