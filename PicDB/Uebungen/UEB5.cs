using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;
using PicDB.Models;
using PicDB.ViewModels;

namespace Uebungen
{
    public class UEB5 : IUEB5
    {
        public void HelloWorld()
        {
        }

        public IBusinessLayer GetBusinessLayer()
        {
            BusinessLayer bl = new BusinessLayer();
            bl.Sync();
            return bl;
        }

        public void TestSetup(string picturePath)
        {
           
        }

        public IPhotographerModel GetEmptyPhotographerModel()
        {
            return new PhotographerModel(); 
        }

        public IPhotographerViewModel GetPhotographerViewModel(IPhotographerModel mdl)
        {
            return new PhotographerViewModel(mdl);
            //throw new NotImplementedException();
        }

        public ICameraModel GetEmptyCameraModel()
        {
            return new CameraModel();
            //throw new NotImplementedException();
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            return new CameraViewModel(mdl);
        }
    }
}
