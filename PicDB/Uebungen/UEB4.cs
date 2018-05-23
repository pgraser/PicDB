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
    public class UEB4 : IUEB4
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

        public IEXIFModel GetEmptyEXIFModel()
        {
            return new EXIFModel();
        }

        public IEXIFViewModel GetEXIFViewModel(IEXIFModel mdl)
        {
            return new EXIFViewModel(mdl);
        }

        public IIPTCModel GetEmptyIPTCModel()
        {
            return new IPTCModel();
        }

        public IIPTCViewModel GetIPTCViewModel(IIPTCModel mdl)
        {
            IIPTCViewModel iptcvm = new IPTCViewModel(mdl);
            return iptcvm;
        }

        public ICameraModel GetCameraModel(string producer, string make)
        {
            return new CameraModel(producer, make);
            //throw new NotImplementedException();
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            return new CameraViewModel(mdl);
        }
    }
}
