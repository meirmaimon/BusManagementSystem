using DLAPI.DO;

namespace DLAPI
{
    public interface IDL
    {
        #region Bus
        IEnumerable<Bus> GetBuses();
        Bus GetBus(int licencePlate);
        void AddBus(Bus bus);
        void RemoveBus(Bus bus);
        void UpdateBus(Bus bus);
        #endregion
        #region Station
        IEnumerable<Station> GetStations();
        Station GetStation(int stationCode);
        void AddStation(Station station);
        void RemoveStation(Station station);
        void UpdateStation(Station station);
        #endregion
        #region Line
        IEnumerable<Line> GetLines();
        Line GetLine(int lineCode);
        void AddLine(Line line);
        void RemoveLine(Line line);
        void UpdateLine(Line line);
        #endregion
        #region User
        IEnumerable<User> GetUsers();
        User GetUser(string userName);
        void UpdateUser(User user);
        void AddUser(User user);
        void RemoveUser(User user);
        #endregion
        #region LineStation
        IEnumerable<LineStation> GetLinesStation();
        LineStation GetLineStation(int lineCode);
        #endregion

    }
}