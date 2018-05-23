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
            get; set;
        }

        public int ID
        {
            get;
        }

        public decimal ISOLimitAcceptable
        {
            get; set;
        }

        public decimal ISOLimitGood
        {
            get; set;
        }

        public bool IsValid
        {
            get
            {
                if (IsValidBoughtOn && IsValidMake && IsValidProducer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string ValidationSummary
        {
            get
            {
                if (IsValid)
                {
                    return string.Empty;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    if (!IsValidBoughtOn)
                    {
                        sb.AppendLine("BoughtOn date is not valid.");
                    }

                    if (!IsValidMake)
                    {
                        sb.AppendLine("Make is not valid.");
                    }

                    if (!IsValidProducer)
                    {
                        sb.AppendLine("Producer is not valid.");
                    }

                    return sb.ToString();
                }
            }
        }

        public bool IsValidProducer
        {
            get
            {
                if (Producer == null || Producer == string.Empty)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool IsValidMake
        {
            get
            {
                if (Make == null || Make == string.Empty)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool IsValidBoughtOn
        {
            get
            {
                if (BoughtOn > DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public string Make
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }

        public int NumberOfPictures
        {
            get;
        }

        public string Producer
        {
            get; set;
        }

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}
