using BIF.SWE2.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.Models
{
    public class EXIFViewModel : IEXIFViewModel
    {
        public EXIFViewModel() { }

        public EXIFViewModel(IEXIFModel model)
        {
            Make = model.Make;
            FNumber = model.FNumber;
            ExposureTime = model.ExposureTime;
            ISOValue = model.ISOValue;
            Flash = model.Flash;
            ExposureProgram = model.ExposureProgram.ToString();
            ExposureProgramResource = "Something";
        }

        public string Make { get; set; }

        public decimal FNumber { get; set; }

        public decimal ExposureTime { get; set; }

        public decimal ISOValue { get; set; }

        public bool Flash { get; set; }

        public string ExposureProgram { get; set; }

        public string ExposureProgramResource { get; set; }

        public ICameraViewModel Camera { get; set; }

        public ISORatings ISORating
        {
            get
            {
                if(ISOValue > 0 && ISOValue <= 400)
                {
                    return ISORatings.Good;
                }
                else if(ISOValue > 400 && ISOValue <= 800)
                {
                    return ISORatings.Acceptable;
                }
                else if(ISOValue > 800 && ISOValue <= 1600)
                {
                    return ISORatings.Noisey;
                }
                else
                {
                    return ISORatings.NotDefined;
                }
            }
            set
            {
                ISORating = value;
            }
        }

        public string ISORatingResource { get; set; }
    }
}
