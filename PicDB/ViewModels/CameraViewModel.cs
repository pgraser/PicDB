using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;
using PicDB.Models;

namespace PicDB.ViewModels
{
    class CameraViewModel : ICameraViewModel
    {
        public CameraViewModel()
        {

        }

        public CameraViewModel(ICameraModel cm)
        {
            _Producer = cm.Producer;
            _Make = cm.Make;
        }

        private DateTime? _Boughton;
        public DateTime? BoughtOn
        {
            get
            {
                return _Boughton;
            }

            set
            {
                _Boughton = value;
            }
        }

        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
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

        private bool _IsValid;
        public bool IsValid
        {
            get
            {
                return _IsValid;
            }
        }

        private bool _IsValidBoughton;
        public bool IsValidBoughtOn
        {
            get
            {
                return _IsValidBoughton;
            }
        }

        private bool _IsValidMake;
        public bool IsValidMake
        {
            get
            {
                return IsValidMake;
            }
        }

        private bool _IsValidProducer;
        public bool IsValidProducer
        {
            get
            {
                return _IsValidProducer;
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

        private int _NumberOfPictures;
        public int NumberOfPictures
        {
            get
            {
                return _NumberOfPictures;
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

        private string _ValidationSummary;
        public string ValidationSummary
        {
            get
            {
                return _ValidationSummary;
            }
        }

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}
