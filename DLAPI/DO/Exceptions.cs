using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DLAPI.DO
{
    [Serializable]
    #region XMLExceptions
    public class XMLLoadException:Exception
    {
        public string  filePath;
        public XMLLoadException(string xmlPath) : base() { filePath = xmlPath; }

        public XMLLoadException(string xmlPath, Exception? innerException) : base(xmlPath, innerException)
        {
            filePath = xmlPath;
        }
        public override string ToString()
        {
            return base.ToString() + $"xml file path {filePath} failed";
        }
    }
    public class XMLEmptyListException : Exception
    {
        public string ListType;

        public XMLEmptyListException(string listType)
        {
            ListType = listType;
        }
        public override string ToString()
        {
            return base.ToString()+$"xml list of type {ListType} has no data";
        }
    }
    #endregion
    #region BusException
    public class BusBadLicenceException : Exception
    {
        public int LicencePlate;

        public BusBadLicenceException(int licence):base()
        {
            LicencePlate = licence;
        }

        public BusBadLicenceException(int licence,string? message) : base(message)
        {
            LicencePlate= licence; 
        }
        public override string ToString()
        {
            return base.ToString() + $"bad licence number{LicencePlate}";
        }
    }
    #endregion
}
