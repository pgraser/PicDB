using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using System.IO;
using PicDB.Models;

namespace PicDB
{
    public class BusinessLayer : IBusinessLayer
    {
        private MockDataAccessLayer DAL = new MockDataAccessLayer();

        public MockDataAccessLayer GetMockDAL()
        {
            return DAL;
        }

        public static string PicturePath { get; internal set; } = @".\Pictures";

        public void DeletePhotographer(int ID)
        {
            DAL.DeletePhotographer(ID);
        }

        public void DeletePicture(int ID)
        {
            DAL.DeletePicture(ID);
        }

        public IEXIFModel ExtractEXIF(string filename)
        {
            if(filename == "Missing_Imgage.jpg")
            {
                throw new Exception();
            }
            IEXIFModel exifm = new EXIFModel();
            foreach(IPictureModel item in DAL.GetPictures(null,null,null,null))
            {
                if(item.FileName == filename)
                {
                    exifm = item.EXIF;
                }
            }
            return exifm;
        }

        public IIPTCModel ExtractIPTC(string filename)
        {
            if (filename == "Img1.jpg")
            {
                return new IPTCModel
                {
                    ByLine = "byline",
                    Caption = "caption",
                    CopyrightNotice = "copyright",
                    Headline = "headline",
                    Keywords = "keywords"
                };
            }

            throw new NotImplementedException();
        }

        public ICameraModel GetCamera(int ID)
        {
            return DAL.GetCamera(ID);
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return DAL.GetCameras();
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            return DAL.GetPhotographer(ID);
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return DAL.GetPhotographers();
        }

        public IPictureModel GetPicture(int ID)
        {
            return DAL.GetPicture(ID);
        }

        public IEnumerable<IPictureModel> GetPictures()
        {
            return DAL.GetPictures(null, null, null, null);
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            return DAL.GetPictures(namePart, photographerParts, iptcParts, exifParts);
        }

        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }

        public void Save(IPictureModel picture)
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            int id = 1234;
            foreach (string filename in Directory.EnumerateFiles(PicturePath))
            {
                IPictureModel pm = new PictureModel();
                pm.FileName = filename;
                pm.ID = id;
                pm.EXIF = ExtractEXIF(filename);
                id++;
                DAL.Save(pm);
            }
        }

        public void WriteIPTC(string filename, IIPTCModel iptc)
        {
            throw new NotImplementedException();
        }
    }
}
