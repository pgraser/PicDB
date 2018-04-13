using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels 
{
    public class SearchViewModel : ISearchViewModel
    {

        public bool IsActive
        {
            get
            {
                if (SearchText == null || SearchText.Equals(string.Empty)) return false;
                return true;
            }
        }

        public int ResultCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private string _SearchText;
        public string SearchText
        {
            get
            {
                return _SearchText;
            }

            set
            {
                _SearchText = value;
            }
        }
    }
}
