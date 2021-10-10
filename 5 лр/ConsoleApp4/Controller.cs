using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Controller
    {
        protected bool isActive = false;
        public string description = "";

        public bool IsActive
        {
            get => this.isActive;
        }

        protected abstract void Handler();
        public abstract void Activate();
        public abstract void Deactivate();

        public virtual string GetClassName()
        {
            return "Controller";
        }
    }
}
