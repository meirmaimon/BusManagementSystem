using DLAPI;
using DLAPI.DO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace DLXML
{
    public class DLXML : IDL
    {

        #region singelton
        static readonly DLXML instance = new DLXML();
        static DLXML() { InitAllLists(); }

        private static void InitAllLists()
        {
            
        }

        public static DLXML Instance { get { return instance; } }
        #endregion

        #region DS XML Files Path
        /// <summary>
        /// users XElement
        /// </summary>
        string UseresPath = @"Useres.xml";
        /// <summary>
        /// busses XMLSerializer
        /// </summary>
        string BusesPath = @"Buses.xml";
        /// <summary>
        /// stations XMLSerializer
        /// </summary>
        string StationsPath = @"Stations.xml";
        /// <summary>
        /// Adjacent Station XMLSerializer
        /// </summary>
        string AdjacentStationPath = @"AdjacentStation.xml";
        /// <summary>
        /// line station XMLSerializer
        /// </summary>
        string LineStationsPath = @"LineStations.xml";
        /// <summary>
        /// bus on trp XMLSerializer
        /// </summary>
        string busOnTripPath = @"BusOnTrip.xml";
        /// <summary>
        /// ID XMLSerializer
        /// </summary>
        string IDisPath = @"IDPath.xml";
        /// <summary>
        /// bus lines XMLSerializer
        /// </summary>
        string LinesPath = @"LinesPath.xml";
        #endregion

        public void AddBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void AddLine(Line line)
        {
            throw new NotImplementedException();
        }

        public void AddStation(Station station)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Bus GetBus(int licencePlate)
        {
            List<Bus> buses = XMLTools.LoadListFromXML<Bus>(BusesPath);
            Bus? curBus = (from bus in buses
                   where bus.LicencePlate == licencePlate
                    select bus).FirstOrDefault();
            if (curBus != null) { return curBus; }
            else
            {
                throw new BusBadLicenceException(licencePlate); 
            }
        }

        public IEnumerable<Bus> GetBuses()
        {
           return XMLTools.LoadListFromXML<Bus>(BusesPath).AsEnumerable<Bus>();   
        }

        public Line GetLine(int lineCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Line> GetLines()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LineStation> GetLinesStation()
        {
            throw new NotImplementedException();
        }

        public LineStation GetLineStation(int lineCode)
        {
            throw new NotImplementedException();
        }

        public Station GetStation(int stationCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> GetStations()
        {
            throw new NotImplementedException();
        }

        public User GetUser(string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RemoveBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void RemoveLine(Line line)
        {
            throw new NotImplementedException();
        }

        public void RemoveStation(Station station)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void UpdateLine(Line line)
        {
            throw new NotImplementedException();
        }

        public void UpdateStation(Station station)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}