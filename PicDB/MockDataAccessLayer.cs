using BIF.SWE2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;
using PicDB.Models;

namespace PicDB
{
    public class MockDataAccessLayer : IDataAccessLayer
    {
        IDictionary<int, IPictureModel> PictureList = new Dictionary<int, IPictureModel>();

        IDictionary<int, ICameraModel> CameraList = new Dictionary<int, ICameraModel>();

        IDictionary<int, IPhotographerModel> PhotographerList = new Dictionary<int, IPhotographerModel>();

        public MockDataAccessLayer()
        {
            CameraModel cm = new CameraModel();
            CameraList.Add(1234, cm);

            PhotographerModel pm = new PhotographerModel();
            pm.ID = 1234;
            PhotographerList.Add(pm.ID, pm);

        }

        public void DeletePhotographer(int ID)
        {
            PhotographerList.Remove(ID);
        }

        public void DeletePicture(int ID)
        {
            PictureList.Remove(ID);
        }

        public ICameraModel GetCamera(int ID)
        {
            return CameraList[ID];
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return CameraList.Values;
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            return PhotographerList[ID];
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return PhotographerList.Values;
        }

        public IPictureModel GetPicture(int ID)
        {
            return PictureList[ID];
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            if (String.IsNullOrEmpty(namePart))
            {
                return PictureList.Values;
            }
            List<IPictureModel> filteredList = new List<IPictureModel>();
            if(namePart == "blume")
            {
                filteredList.Add(new PictureModel());
            }
            return filteredList;
        }

        public void Save(IPhotographerModel photographer)
        {
            PhotographerList.Add(photographer.ID, photographer);
        }

        public void Save(IPictureModel picture)
        {
            if (!PictureList.ContainsKey(picture.ID))
            {
                PictureList.Add(picture.ID, picture);
            }

        }
    }
}
