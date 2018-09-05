using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    public class EXIFModel : IEXIFModel
    {
        public EXIFModel()
        {
            _Make = "Canon";
            FNumber = 14.0m;
            _ExposureTime = 0.5m;
            _ISOValue = 400;
        }

        private ExposurePrograms _ExposureProgram;
        public ExposurePrograms ExposureProgram
        {
            get
            {
                return _ExposureProgram;
            }

            set
            {
                _ExposureProgram = value;
            }
        }

        private decimal _ExposureTime;
        public decimal ExposureTime
        {
            get
            {
                return _ExposureTime;
            }

            set
            {
                _ExposureTime = value;
            }
        }

        private bool _Flash;
        public bool Flash
        {
            get
            {
                return _Flash;
            }

            set
            {
                _Flash = value;
            }
        }

        private decimal _FNumber;
        public decimal FNumber
        {
            get
            {
                return _FNumber;
            }

            set
            {
                _FNumber = value;
            }
        }

        private decimal _ISOValue;
        public decimal ISOValue
        {
            get
            {
                return _ISOValue;
            }

            set
            {
                _ISOValue = value;
            }
        }

        private string _Make;
        public string Make
        {
            get
            {
                return _Make;
            }

            set
            {
                _Make = value;
            }
        }
    }
}
