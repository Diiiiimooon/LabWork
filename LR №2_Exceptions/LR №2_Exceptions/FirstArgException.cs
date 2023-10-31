using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR__2_Exceptions
{
    internal class FirstArgException:Exception
    {
        public override string Message
    {
        get
        {
            return "Коэффициент a равен 0";
        }
    }
}
}
