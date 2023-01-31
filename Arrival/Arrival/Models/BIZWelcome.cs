using Arrival._Statics;
using Arrival.DB;
using System;

namespace Arrival.Models
{
    public class BIZWelcome
    {
        public DTOWelcome GetByCPR(string cpr) 
        {
            if (cpr.IsNullOrEmpty())
                throw new Exception();

            ArrivalDatabase database = new ArrivalDatabase();
            DTOCitizen _c = database.GetItemsByCPR(cpr);
            if (_c.IsNull())
                throw new Exception();

            DTOWelcome dto = new DTOWelcome();
            dto.Welcome = "Velkommen " + _c.FirstName + " " + _c.LastName;

            dto.Message = CheckHelper.IsEven(cpr) ?
                 "Gå venligst til receptionen,hvor der ligger besked til dig." :
                 "Tag venligst plads i venteværelset.";

            return dto;
        }
    }
}
