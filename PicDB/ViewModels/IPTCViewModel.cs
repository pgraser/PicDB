using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicDB.Models
{
    public class IPTCViewModel : IIPTCViewModel
    {
        public IPTCViewModel() { }

        public IPTCViewModel(IIPTCModel model)
        {
            Keywords = model.Keywords;
            ByLine = model.ByLine;
            CopyrightNotice = model.CopyrightNotice;
            Headline = model.Headline;
            Caption = model.Caption;

            CopyrightNotices = new List<string>();
            ((List<string>)CopyrightNotices).Add("All rights reserved.");
            ((List<string>)CopyrightNotices).Add("CC-BY");
            ((List<string>)CopyrightNotices).Add("CC-BY-SA");
        }

        public string Keywords { get; set; }
        public string ByLine { get; set; }
        public string CopyrightNotice { get; set; }

        public IEnumerable<string> CopyrightNotices { get; set; }

        public string Headline { get; set; }
        public string Caption { get; set; }
    }
}
