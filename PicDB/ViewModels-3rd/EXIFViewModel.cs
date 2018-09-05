using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB.Models;
using BIF.SWE2.Interfaces.Models;

namespace PicDB.ViewModels
{
    public class EXIFViewModel : IEXIFViewModel
    {
        public EXIFViewModel()
        {

        }

        public EXIFViewModel(IEXIFModel em)
        {
            ExposureProgram = em.ExposureProgram.ToString();
            ExposureProgramResource = "hi";
            ExposureTime = em.ExposureTime;
            Flash = em.Flash;
            FNumber = em.FNumber;
            ISOValue = em.ISOValue;
            Make = em.Make;
        }

        private ICameraViewModel _camera;
        public ICameraViewModel Camera
        {
            get
            {
                return _camera;
            }

            set
            {
                _camera = value;
            }
        }

        public string ExposureProgram
        {
            get;            set;
        }

        public string ExposureProgramResource
        {
            get; set;
        }

        public decimal ExposureTime
        {
            get; set;
        }

        public bool Flash
        {
            get; set;
        }

        public decimal FNumber
        {
            get; set;
        }

        public ISORatings ISORating
        {
            get; set;
        }

        public string ISORatingResource
        {
            get; set;
        }

        public decimal ISOValue
        {
            get; set;
        }

        public string Make
        {
            get; set;
        }
    }
}
