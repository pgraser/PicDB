using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    class EXIFViewModel : IEXIFViewModel
    {
        public ICameraViewModel Camera
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

        public string ExposureProgram
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ExposureProgramResource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal ExposureTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Flash
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal FNumber
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ISORatings ISORating
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ISORatingResource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal ISOValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Make
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
