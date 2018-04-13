using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    class MainWindowViewModel : IMainWindowViewModel
    {
        private IPictureViewModel _CurrentPicture = new PictureViewModel();
        public IPictureViewModel CurrentPicture
        {
            get
            {
                return _CurrentPicture;
            }
        }

        private IPictureListViewModel _List = new PictureListViewModel();
        public IPictureListViewModel List
        {
            get
            {
                return _List;
            }
        }

        private ISearchViewModel _Search = new SearchViewModel();
        public ISearchViewModel Search
        {
            get
            {
                return _Search;
            }
        }
    }
}
