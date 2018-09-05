using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    class IPTCViewModel : IIPTCViewModel
    {
        private IIPTCModel mdl;

        public IPTCViewModel()
        {
        }

        public IPTCViewModel(IIPTCModel mdl)
        {
            Keywords = mdl.Keywords;
            ByLine = mdl.ByLine;
            CopyrightNotice = mdl.CopyrightNotice;
            Headline = mdl.Headline;
            Caption = mdl.Caption;

            CopyrightNotices = new List<string>();
            ((List<string>)CopyrightNotices).Add("All rights reserved.");
            ((List<string>)CopyrightNotices).Add("CC-BY");
            ((List<string>)CopyrightNotices).Add("CC-BY-SA");
        }

        public string ByLine
        {
            get; set;
        }

        public string Caption
        {
            get; set;
        }

        public string CopyrightNotice
        {
            get; set;
        }

        public IEnumerable<string> CopyrightNotices
        {
            get; set;
        }

        public string Headline
        {
            get; set;
        }

        public string Keywords
        {
            get; set;
        }
    }
}
