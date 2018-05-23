using BIF.SWE2.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;

namespace PicDB.Models
{
    public class EXIFModel : IEXIFModel
    {
        public EXIFModel()
        {
            FNumber = 14.0m;
            ExposureTime = 0.5m;
            ISOValue = 400;
            Make = "Canon";
        }


        public string Make { get; set; }
        public decimal FNumber { get; set; }
        public decimal ExposureTime { get; set; }
        public decimal ISOValue { get; set; }
        public bool Flash { get; set; }
        public ExposurePrograms ExposureProgram { get; set; }
    }
}
