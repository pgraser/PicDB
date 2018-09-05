using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;

using PicDB.Models;

namespace PicDB.ViewModels
{
    public class PictureViewModel : IPictureViewModel
    {
        public PictureViewModel()
        {
        }

        public PictureViewModel(IPictureModel pm)
        {
            _FileName = pm.FileName;
        }

        private CameraViewModel _Camera = new CameraViewModel();
        public ICameraViewModel Camera
        {
            get
            {
                return _Camera;
            }
        }

        private string _DisplayName;
        public string DisplayName
        {
            get
            {
                if (_DisplayName == null)
                {
                    _DisplayName = (FileName + " (by " + _Photographer.FirstName + " " + _Photographer.LastName + ")");
                }

                return _DisplayName;
            }
        }

        private IEXIFViewModel _EXIF = new EXIFViewModel();
        public IEXIFViewModel EXIF
        {
            get
            {
                return _EXIF;
            }
        }

        private string _FileName;
        public string FileName
        {
            get
            {
                return _FileName;
            }
        }

        private string _FilePath;
        public string FilePath
        {
            get
            {
                return _FilePath;
            }
        }

        public int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
        }

        private IIPTCViewModel _IPTC = new IPTCViewModel();
        public IIPTCViewModel IPTC
        {
            get
            {
                return _IPTC;
            }
        }

        private PhotographerViewModel _Photographer = new PhotographerViewModel();
        public IPhotographerViewModel Photographer
        {
            get
            {
                return _Photographer;
            }
        }
    }
}
