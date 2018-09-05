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
            Producer = cm.Producer;
            Make = cm.Make;
            ISOLimitAcceptable = cm.ISOLimitAcceptable;
            ISOLimitGood = cm.ISOLimitGood;
        }

        public DateTime? BoughtOn
        {
            get;

            set;
        }

        public int ID
        {
            get;
        }

        public decimal ISOLimitAcceptable
        {
            get;

            set;
        }

        public decimal ISOLimitGood
        {
            get;

            set;
        }

        public bool IsValid
        {
            get;
        }

        public bool IsValidBoughtOn
        {
            get;
        }

        public bool IsValidMake
        {
            get;
        }

        public bool IsValidProducer
        {
            get;
        }

        public string Make
        {
            get;

            set;
        }

        public string Notes
        {
            get;

            set;
        }

        public int NumberOfPictures
        {
            get;
        }

        public string Producer
        {
            get;

            set;
        }

        public string ValidationSummary
        {
            get;
        }

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}
