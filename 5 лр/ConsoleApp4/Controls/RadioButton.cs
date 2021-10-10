using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Controls
{
    class RadioButton: Controller
    {
        public RadioButton(bool isActive = false, string description = "")
        {
            this.isActive = isActive;
            this.description = description;
        }

        protected override void Handler()
        {
            Console.WriteLine("Do smth...");
        }

        public override void Activate()
        {
            this.isActive = true;
            this.Handler();
        }

        public override void Deactivate()
        {
            this.isActive = false;
            Console.WriteLine("RadioButton was deactivated...");
        }

        public override string GetClassName()
        {
            return "RadioButton";
        }

        public override string ToString()
        {
            return $"{"".PadLeft(12, '-')} INFO {"".PadLeft(12, '-')}\n" +
                $"Class: {this.GetClassName()}\n" +
                $"IsActive: {this.IsActive}\n" +
                $"Description: {this.description}\n" +
                $"{"".PadLeft(30, '-')}";
        }
    }
}
