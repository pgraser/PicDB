using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB.Models;
using PicDB.ViewModels;
using PicDB;

namespace Uebungen
{
    public class UEB2 : IUEB2
    {
        public void HelloWorld()
        {
        }

        public IBusinessLayer GetBusinessLayer()
        {
            return new BusinessLayer();
        }

        public BIF.SWE2.Interfaces.ViewModels.IMainWindowViewModel GetMainWindowViewModel()
        {
            return new MainWindowViewModel();
        }

        public BIF.SWE2.Interfaces.Models.IPictureModel GetPictureModel(string filename)
        {
            PictureModel pm = new PictureModel();
            pm.FileName = filename;
            return pm;
        }

        public BIF.SWE2.Interfaces.ViewModels.IPictureViewModel GetPictureViewModel(BIF.SWE2.Interfaces.Models.IPictureModel mdl)
        {
            PictureViewModel pvm = new PictureViewModel(mdl);
            return pvm;
        }

        public void TestSetup(string picturePath)
        {
            BusinessLayer.PicturePath = picturePath;
        }

        public ICameraModel GetCameraModel(string producer, string make)
        {
            CameraModel cm = new CameraModel();
            cm.Producer = producer;
            cm.Make = make;
            return cm;
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            ICameraViewModel clvm = new CameraViewModel(mdl);
            return clvm;
        }
    }
}
