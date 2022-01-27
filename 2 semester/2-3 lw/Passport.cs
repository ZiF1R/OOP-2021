using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;

namespace _2_lw
{
    [Serializable]
    [DataContract]
    public class Passport
    {
        [DataMember]
        private string number;
        [DataMember]
        public DateTimeOffset ExpiresDate { get; set; }

        public string Number
        {
            get => this.number;
            set
            {
                if (value.Length == 14)
                    this.number = value;
            }
        }

        public Passport() { }

        public Passport(string number, DateTimeOffset expiresDate)
        {
            this.ExpiresDate = expiresDate;
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{this.Number}:{this.ExpiresDate}";
        }
    }
}
