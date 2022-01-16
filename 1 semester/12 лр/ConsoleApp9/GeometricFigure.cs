using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    [Serializable] [DataContract]
    public class GeometricFigure
    {
        [DataMember]
        private double height;
        [DataMember]
        private double width;
        [DataMember]
        public double square;

        protected static int objCount = 0;

        public int ObjCount
        {
            get => objCount;
        }

        public double Height
        {
            get => height;
            set
            {
                if (value >= 0) height = value;
                else throw new Exception("Height can't be less than 0!");
            }
        }
        
        public double Width
        {
            get => width;
            set
            {
                if (value >= 0) width = value;
                else throw new Exception("Width can't be less than 0!");
            }
        }

        public GeometricFigure() { }

        public GeometricFigure(double height = 0, double width = 0)
        {
            this.Height = height;
            this.Width = width;
            this.square = this.Height * this.Width;
            objCount++;
        }


        // methods

        public virtual string getClassName()
        {
            return "GeometricFigure";
        }

        // override methods

        public override string ToString()
        {
            return $"[Height: {this.Height} Width: {this.Width}]\n";
        }

        public override bool Equals(object obj)
        {
            GeometricFigure tmp = obj as GeometricFigure;
            if (this.Width == tmp.Width && this.Height == tmp.Height)
                return true;
            return false;
        }
    }
}
