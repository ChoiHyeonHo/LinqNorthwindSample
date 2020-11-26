﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAC;
using NorthwindVO;

namespace WinNorthwind.Services
{
    class CommonService
    {
        public List<ComboItemVO> GetCodeInfoByCodeTypes(string[] types)
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCodeInfoByCodeTypes(types);
        }
    }
}
