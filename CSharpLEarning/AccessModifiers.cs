using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLEarning
{
    public class AccessModifiers
    {
        // Public can be accessed anywhere in the project

        protected int parentInt { get; set; } = 25;

        internal int parentInt2 { get; set; } = 30;

        protected internal int parentInt3 { get; set; } = 35;
        public void Print() {
            //Private vars can only be accessed in the class or structure
            this.PrintModifiers();
        }

        private void PrintModifiers() { }
    }

    public class ChildAccessModifier : AccessModifiers
    {
        public ChildAccessModifier() 
        {
            this.parentInt = 25;// it is accessible because it is derived class
        }
    }

}
