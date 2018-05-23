using BIF.SWE2.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicDB.Models
{
    public class IPTCModel : IIPTCModel
    {
        public IPTCModel()
        {
            ByLine = " not set";
            Keywords = " not set";
            CopyrightNotice = " not set";
            Headline = " not set";
            Caption = " not set";
        }

        public string Keywords { get; set; }
        public string ByLine { get; set; }
        public string CopyrightNotice { get; set; }
        public string Headline { get; set; }
        public string Caption { get; set; }
    }
}
