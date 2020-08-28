using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos
{
    class enumDemo
    {
        public enum LocaleCountryCodeEnum
        {
            Arabic = 1,
            English = 2,
            Greek = 3,
            Norweign = 4
        }

        public enum LocaleDateFormatEnum
        {
            yyyyMd = 1,
            Mdyyyy = 2,
            dMyyyy = 3,
            ddMMyyyy = 4
        }
    }
}
