using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    class PictureListViewModel : IPictureListViewModel
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int CurrentIndex
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPictureViewModel CurrentPicture
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string CurrentPictureAsString
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPictureViewModel> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPictureViewModel> NextPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPictureViewModel> PrevPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
