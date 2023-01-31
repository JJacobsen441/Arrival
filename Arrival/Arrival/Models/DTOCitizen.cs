using SQLite;

namespace Arrival.Models
{
    public class DTOCitizen
    {
        [Column("ID")]
        public int ID { get; set; }


        [Column("CPR")]
        public string CPR { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }
    }
}
