using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9lw.DB_Entities
{
    [Table("ACCOUNT")]
    public class Account
    {
		[Key]
		public int? NUMBER { get; set; }
		public int ACCOUNT_OWNER { get; set; }
        //public AccountOwner AccountOwner { get; set; }
        public string DEPOSIT_TYPE { get; set; }
		public decimal BALANCE { get; set; }
	    public DateTime OPENING_DATE { get; set; }
		public string NOTIFICATIONS { get; set; }
		public string INTERNET_BANKING { get; set; }
		public byte[] CLIENT_IMAGE { get; set; }

		public Account()
        {
			NUMBER = 0;
			ACCOUNT_OWNER = 0;
			DEPOSIT_TYPE = "";
			BALANCE = 0;
			OPENING_DATE = new DateTime();
			NOTIFICATIONS = "off";
			INTERNET_BANKING = "off";
			CLIENT_IMAGE = null;
		}

		public Account(int ownerId, string deposit, decimal balance, DateTime opening, string notific, string banking, byte[] image)
		{
			NUMBER = 0;
			ACCOUNT_OWNER = ownerId;
			DEPOSIT_TYPE = deposit;
			BALANCE = balance;
			OPENING_DATE = opening;
			NOTIFICATIONS = notific;
			INTERNET_BANKING = banking;
			CLIENT_IMAGE = image;
		}
	}
}
