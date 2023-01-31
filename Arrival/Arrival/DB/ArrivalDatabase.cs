using Arrival._Common;
using Arrival._Statics;
using Arrival.Models;
using SQLite;
using System;
using System.Collections.Generic;

namespace Arrival.DB
{
    public class ArrivalDatabase
    {
        static SQLiteConnection Database;

        public ArrivalDatabase()
        {
            Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            CreateTableResult result = Database.CreateTable<DTOCitizen>();
        }


        //...


        public DTOCitizen GetItemsByCPR(string cpr)
        {
            if (cpr.IsNullOrEmpty())
                throw new Exception();

            List<DTOCitizen> list = Database.Query<DTOCitizen>("SELECT * FROM DTOCitizen WHERE CPR = '" + cpr + "'");
            if (list.IsNullOrEmpty())
                return null;

            return list[0];
        }

        public List<DTOCitizen> GetItems()
        {
            List<DTOCitizen> list = Database.Table<DTOCitizen>().ToList();
            if (list.IsNullOrEmpty())
                throw new Exception();

            return list;
        }

        public DTOCitizen GetItem(int id)
        {
            DTOCitizen dto = Database.Table<DTOCitizen>().Where(i => i.ID == id).FirstOrDefault();
            if (dto.IsNull())
                throw new Exception();

            return dto;
        }

        public int SaveItem(DTOCitizen item)
        {
            if (item.IsNull())
                throw new Exception();

            if (item.ID != 0)
            {
                return Database.Update(item);
            }
            else
            {
                return Database.Insert(item);
            }
        }

        public int DeleteItem(DTOCitizen item)
        {
            if (item.IsNull())
                throw new Exception();

            return Database.Delete(item);
        }
    }
}
