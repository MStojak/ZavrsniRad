using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.Generic
{
    public class MakeBooleanToYesNo : IMakeBooleanToYesNo
    {
        public MakeBooleanToYesNo()
        {

        }

        public string getAnswer(bool b)
        {
            if (b)
                return "Yes";
            else
                return "No";
        }
    }
}
