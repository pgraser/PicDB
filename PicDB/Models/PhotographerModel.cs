using BIF.SWE2.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicDB.Models
{
    public class PhotographerModel : IPhotographerModel
    {
        public PhotographerModel()
        {
            ID = NextID++;
        }

        public PhotographerModel(int ID)
        {
            this.ID = ID;
        }

        protected static int NextID = 1;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Notes { get; set; }
    }
}
