using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB.ViewModels
{
    public class PhotographerViewModel : IPhotographerViewModel
    {
        public PhotographerViewModel()
        {

        }


        private DateTime? _BirthDay;
        public DateTime? BirthDay
        {
            get
            {
                return _BirthDay;
            }

            set
            {
                _BirthDay = value;
            }
        }

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
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

        private bool _IsValid;
        public bool IsValid
        {
            get
            {
                return _IsValid;
            }
        }

        private bool _IsValidBirthday;
        public bool IsValidBirthDay
        {
            get
            {
                return _IsValidBirthday;
            }
        }

        private bool _IsValidLastName;
        public bool IsValidLastName
        {
            get
            {
                return _IsValidLastName;
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
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

        private string _ValidationSummary;
        public string ValidationSummary
        {
            get
            {
                return _ValidationSummary;
            }
        }
    }
}
