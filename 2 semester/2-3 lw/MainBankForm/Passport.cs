﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace _2_lw
{
    [Serializable]
    [DataContract]
    public class Passport
    {
        [DataMember]
        [Required]
        [StringLength(14, ErrorMessage = "Passport number must be 14-symbol string!")]
        private string passportNumber;

        [DataMember]
        public DateTime ExpiresDate { get; set; }

        public string PassportNumber
        {
            get => this.passportNumber;
            set
            {
                    this.passportNumber = value;
            }
        }

        public Passport() { }

        public Passport(string number, DateTime expiresDate)
        {
            this.ExpiresDate = expiresDate;
            this.PassportNumber = number;
        }

        public override string ToString()
        {
            return $"{this.PassportNumber}:{this.ExpiresDate}";
        }
    }
}
