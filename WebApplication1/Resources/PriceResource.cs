using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication1.Resources
{
    public class PriceResource
    {
        private static string _ResourceAdress = "https://datahub.io/core/oil-prices/r/brent-daily.json";

        private static List<Point> LoadListFromWeb()
        {
            using(WebClient wc = new WebClient())
            {
                string json = string.Empty;

                try
                {
                    json = wc.DownloadString(_ResourceAdress);

                    List<Point> pnt = JsonConvert.DeserializeObject<List<Point>>(json);

                    return pnt;
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
        
        public static List<Point> GetPricesList()
        {
            List<Point> lst = LoadListFromWeb();

            return lst != null ? LoadListFromWeb().ToList() : new List<Point>();
        }

        public static List<Point> GetPricesListRange(DateTime from, DateTime to)
        {
            List<Point> lst = LoadListFromWeb();

            return lst != null ? lst.Where(o => o.Date >= from && o.Date <= to).ToList() : new List<Point>();
        }

        //Se volessimo scaricare i dati una sola volta perchè ipotizziamo che siano costanti
        //è possibile avvalersi dell'istanza statica _PricesList
        //modificando i metodi Get utilizzando LoadList invece di LoadListFromWeb
        private static List<Point> _PricesList = null;

        private static List<Point> LoadList()
        {
            if (_PricesList == null)
            {
                _PricesList = LoadListFromWeb();
            }

            return _PricesList;
        }
    }
}
