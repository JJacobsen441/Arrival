using Arrival._Statics;
using Arrival.DB;
using System;
using System.Collections.Generic;

namespace Arrival.Models
{
    public class BIZCitizen
    {
        public void SaveItem(DTOCitizen item) 
        {
            if (item.IsNull())
                throw new Exception();

            ArrivalDatabase database = new ArrivalDatabase();
            database.SaveItem(item);
        }

        public List<DTOCitizen> GetItems()
        {
            ArrivalDatabase database = new ArrivalDatabase();
            List<DTOCitizen> list = database.GetItems();
            if (list.IsNullOrEmpty())
                throw new Exception();

            return list;
        }
    }
}
