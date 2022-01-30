using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace _2_lw
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class BirthDateValidation: ValidationAttribute
    {
        readonly DateTimeOffset _minBirthDate;

        public DateTimeOffset MinBirthDate
        {
            get { return _minBirthDate; }
        }

        public BirthDateValidation(string date)
        {
            if (!DateTimeOffset.TryParse(date, out this._minBirthDate))
                throw new ArgumentException("Wrong date format!");
        }

        public override bool IsValid(object value)
        {
            DateTimeOffset enteredDate = (DateTimeOffset)value;
            return enteredDate <= this.MinBirthDate;
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
              ErrorMessageString, name, this.MinBirthDate);
        }
    }
}
