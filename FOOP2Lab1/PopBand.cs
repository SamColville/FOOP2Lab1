﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOP2Lab1
{
    class PopBand : Band
    {
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", BandName, Genre, Year.ToString());
        }
    }
}
