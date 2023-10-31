using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR__2_Exceptions
{
    internal class NegativeDiscriminantException : Exception
    {
        public override string Message
        {
            get
            {
                return "Дискриминант меньше нуля";
            }
        }
    }
}
