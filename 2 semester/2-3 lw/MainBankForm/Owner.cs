using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace _2_lw
{
    [Serializable]
    [DataContract]
    public class Owner
    {
        [DataMember]
        [Required]
        [RegularExpression(@"[\W|\d]+$",
         ErrorMessage = "Surname should be filled and contain only alphabetic symbols!")]
        private string surname;

        [DataMember]
        [Required]
        [RegularExpression(@"[\W|\d]+$",
         ErrorMessage = "Name should be filled and contain only alphabetic symbols!")]
        private string name;

        [DataMember]
        [Required]
        [RegularExpression(@"[\W|\d]+$",
         ErrorMessage = "Patronimic should be filled and contain only alphabetic symbols!")]
        private string patronimic;

        [DataMember]
        [BirthDateValidation("2003-1-1",
            ErrorMessage = "The age of bank clients must be at least 18 years old")]
        private DateTimeOffset birthDate;

        [DataMember]
        [Required]
        private Passport ownerPassport;

        public string Surname
        {
            get => this.surname;
            set
            {
                if(value.Length != 0)
                    this.surname = value;
            }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length != 0)
                    this.name = value;
            }
        }

        public string Patronimic
        {
            get => this.patronimic;
            set
            {
                if (value.Length != 0)
                    this.patronimic = value;
            }
        }

        public DateTimeOffset BirthDate
        {
            get => this.birthDate;
            set
            {
                this.birthDate = value;
            }
        }

        public Passport OwnerPassport
        {
            get => this.ownerPassport;
            set
            {
                this.ownerPassport = value;
            }
        }

        public Owner() { }

        public Owner(string surname, string name, string patronimic, DateTimeOffset birthDate, Passport ownerPassport)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronimic = patronimic;
            this.BirthDate = birthDate;
            this.OwnerPassport = ownerPassport;
        }
    }
}
