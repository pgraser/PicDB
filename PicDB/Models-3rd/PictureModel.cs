using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    public class PictureModel : IPictureModel
    {
        public PictureModel()
        {

        }

        public ICameraModel _Camera = new CameraModel();
        public ICameraModel Camera
        {
            get
            {
                return _Camera;
            }

            set
            {
                _Camera = value;
            }
        }

        private IEXIFModel _EXIF;
        public IEXIFModel EXIF
        {
            get
            {
                return _EXIF;
            }

            set
            {
                _EXIF = value;
            }
        }

        private string _FileName;

        public string FileName
        {
            get
            {
                return _FileName;
            }

            set
            {
                _FileName = value;
            }
        }

        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public IIPTCModel IPTC
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
