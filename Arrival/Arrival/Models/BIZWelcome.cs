using Arrival._Statics;
using Arrival.DB;
using System;
using System.Collections.Generic;
using System.Text;

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

            if (CheckHelper.IsEven(cpr))
                dto.Message = "Gå venligst til receptionen,hvor der ligger besked til dig";
            else
                dto.Message = "Tag venligst plads i venteværelset.";

            return dto;
        }
    }
}
