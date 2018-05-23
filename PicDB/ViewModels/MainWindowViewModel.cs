using BIF.SWE2.Interfaces.ViewModels;
using PicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicDB.Models
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public IPictureViewModel CurrentPicture => new PictureViewModel();

        public IPictureListViewModel List => new PictureListViewModel();

        public ISearchViewModel Search => new SearchViewModel();
    }
}
