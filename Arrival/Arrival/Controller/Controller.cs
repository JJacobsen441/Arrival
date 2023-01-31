using Arrival._Statics;
using Arrival.DB;
using Arrival.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arrival.Controllers
{
    public class Controller
    {
        public DTOWelcome GetByCPR(string cpr)
        {
            BIZWelcome biz = new BIZWelcome();
            DTOWelcome dto = biz.GetByCPR(cpr);

            return dto;
        }

        public void SaveItem(DTOCitizen item)
        {
            BIZCitizen biz = new BIZCitizen();
            biz.SaveItem(item);
        }

        public List<DTOCitizen> GetItems() 
        {
            BIZCitizen biz = new BIZCitizen();
            List<DTOCitizen> list = biz.GetItems();

            return list;
        }
    }
}
