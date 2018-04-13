using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;


namespace PicDB.Models
{
    class CameraModel : ICameraModel
    {
        private DateTime? _BroughtOn;
        public DateTime? BoughtOn
        {
            get
            {
                return _BroughtOn;
            }

            set
            {
                _BroughtOn = value;
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

        private decimal _ISOLimitAcceptable;
        public decimal ISOLimitAcceptable
        {
            get
            {
                return _ISOLimitAcceptable;
            }

            set
            {
                _ISOLimitAcceptable = value;
            }
        }

        private decimal _ISOLimitGood;
        public decimal ISOLimitGood
        {
            get
            {
                return _ISOLimitGood;
            }

            set
            {
                _ISOLimitGood = value;
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

        private string _Notes;
        public string Notes
        {
            get
            {
                return _Notes;
            }

            set
            {
                _Notes = value;
            }
        }

        private string _Producer;
        public string Producer
        {
            get
            {
                return _Producer;
            }

            set
            {
                _Producer = value;
            }
        }
    }
}
