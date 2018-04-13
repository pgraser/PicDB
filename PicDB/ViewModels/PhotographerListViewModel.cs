using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    class PhotographerListViewModel : IPhotographerListViewModel
    {
        public IPhotographerViewModel CurrentPhotographer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPhotographerViewModel> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
