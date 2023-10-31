using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR__2_Exceptions
{
    internal class IncorrectDataException : Exception
    {
        public override string Message
        {
            get
            {
                return "Данные представлены некорректно";
            }
        }
    }
}
