using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB.Models;

namespace PicDB.ViewModels
{
    class PictureListViewModel : ViewModelNotifier, IPictureListViewModel
    {
        private BusinessLayer bl;

        public PictureListViewModel()
        {
            bl = new BusinessLayer();
            SyncAndUpdatePictureList();
        }

        public void SyncAndUpdatePictureList()
        {
            bl.Sync();
            var pictures = bl.GetPictures();
            CurrentPicture = null;
            _list.Clear();
            foreach (IPictureModel model in pictures)
            {
                _list.Add(new PictureViewModel((PictureModel)model));
            }
            _backupList = new ObservableCollection<IPictureViewModel>(_list);

            int firstModelID = _list.First().ID;
            CurrentPicture = new PictureViewModel(bl.GetPicture(firstModelID));
        }

        public IEnumerable<IPictureViewModel> PrevPictures { get; set; }

        public IEnumerable<IPictureViewModel> NextPictures { get; set; }

        public int Count { get; set; }

        public int CurrentIndex { get; set; }

        public string CurrentPictureAsString { get; set; }

        private IPictureViewModel _currentPicture;
        public IPictureViewModel CurrentPicture
        {
            get => _currentPicture;
            set
            {
                if (_currentPicture != value)
                {
                    _currentPicture = value;
                    NotifyPropertyChanged(nameof(CurrentPicture));
                }
            }
        }

        private ObservableCollection<IPictureViewModel> _backupList;
        private ObservableCollection<IPictureViewModel> _list = new ObservableCollection<IPictureViewModel>();

        public IEnumerable<IPictureViewModel> List
        {
            get => _list;
            set
            {
                _list = (ObservableCollection<IPictureViewModel>)value;
                NotifyPropertyChanged("List");
            }
        }

        public void ResetList()
        {
            _list = new ObservableCollection<IPictureViewModel>(_backupList);
        }
    }
}
