using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _2_lw
{
    [Serializable]
    [DataContract]
    public class BankAccount
    {
        [DataMember]
        [Required]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Account number must be 9-digit number!")]
        private int number;

        [DataMember]
        [Required]
        private string depositType;

        [DataMember]
        [Required]
        private DateTimeOffset openingDate;

        [DataMember]
        [Required]
        private Owner accountOwner;

        [DataMember]
        public int Balance { get; set; }

        [DataMember]
        public bool Notifications { get; set; }

        [DataMember]
        public bool InternetBanking { get; set; }

        public int Number
        {
            get => this.number;
            set
            {
                if (value.ToString().Length == 9)
                    this.number = value;
                else throw new ArgumentException("Account number must be 9-digit number!");
            }
        }

        public string DepositType
        {
            get => this.depositType;
            set
            {
                string[] depositTypes = { "Накопительный", "Расчетный", "Сберегательный", "Срочный" };
                if (depositTypes.Contains(value)) this.depositType = value;
                else throw new ArgumentException("Invalid deposit type!");
            }
        }

        public DateTimeOffset OpeningDate
        {
            get => this.openingDate;
            set
            {
                this.openingDate = value;
            }
        }

        public Owner AccountOwner
        {
            get => this.accountOwner;
            set
            {
                this.accountOwner = value;
            }
        }

        public BankAccount() { }

        public BankAccount(int number, string depositType, DateTimeOffset openingDate, Owner accountOwner, int balance, bool notifications, bool internetBanking)
        {
            this.Number = number;
            this.DepositType = depositType;
            this.OpeningDate = openingDate;
            this.AccountOwner = accountOwner;
            this.Balance = balance;
            this.Notifications = notifications;
            this.InternetBanking = internetBanking;
        }

        public override string ToString()
        {
            return $"Bank account number: {this.Number}" + Environment.NewLine +
                $"Deposit type: {this.DepositType}" + Environment.NewLine +
                $"Opening date: {this.OpeningDate}" + Environment.NewLine +
                $"Owner: {this.AccountOwner.Surname} {this.AccountOwner.Name} {this.AccountOwner.Patronimic}" + Environment.NewLine +
                $"Balance: ${this.Balance}" + Environment.NewLine +
                $"Notifications: {(this.Notifications ? "on" : "off")}" + Environment.NewLine +
                $"Internet banking: {(this.InternetBanking ? "on" : "off")}" + Environment.NewLine;
        }
    }
}
