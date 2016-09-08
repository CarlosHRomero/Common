using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.OBJ
{
    public class UserException : Exception
    {

        public override string Message
        {
            get
            {
                return "Usuario ya exite";
            }
        }


    }
}
