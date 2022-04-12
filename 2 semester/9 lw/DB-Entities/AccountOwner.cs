using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9lw.DB_Entities
{
    [Table("ACCOUNT_OWNER")]
    public class AccountOwner
    {
        [Key]
        public int? OWNER_ID { get; set; }
        public int PASSPORT_NUMBER { get; set; }
        public DateTime BIRTH_DATE { get; set; }
	    public string SURNAME { get; set; }
        public string NAME { get; set; }
        public string PATRONIMIC { get; set; }

        public AccountOwner()
        {
            OWNER_ID = 0;
            PASSPORT_NUMBER = 0;
            BIRTH_DATE = new DateTime();
            SURNAME = "";
            NAME = "";
            PATRONIMIC = "";
        }

        public AccountOwner(int passport, DateTime date, string surname, string name, string patronimic)
        {
            OWNER_ID = 0;
            PASSPORT_NUMBER = passport;
            BIRTH_DATE = date;
            SURNAME = surname;
            NAME = name;
            PATRONIMIC = patronimic;
        }
    }
}
