using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicDB.Models
{
    public class PictureViewModel : MainWindowViewModel, IPictureViewModel
    {
        public PictureViewModel() { }

        public PictureViewModel(IPictureModel model)
        {
            if (model != null)
            {
                FileName = model.FileName;

                string name = model.FileName;
                string by = model.IPTC.ByLine;

                DisplayName = name + " (by " + by + ")";
            }
        }

        public int ID { get { throw new NotImplementedException(); } }

        public string FileName { get; set; }

        public string FilePath { get { throw new NotImplementedException(); } }

        public string DisplayName { get; set; }

        public IIPTCViewModel IPTC => new IPTCViewModel();

        public IEXIFViewModel EXIF => new EXIFViewModel();

        public IPhotographerViewModel Photographer { get { throw new NotImplementedException(); } }

        public ICameraViewModel Camera => new CameraViewModel();
    }
}
