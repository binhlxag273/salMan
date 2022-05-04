using log4net;
using log4net.Config;

namespace UtilityLayer
{
    public class Logging
    {
        private Logging()
        {
            XmlConfigurator.Configure();
            _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            _log.Info("Start Logging");
        }

        private static Logging _instance;
        private ILog _log;

        public static Logging Instance()
        {
            if (_instance == null)
            {
                _instance = new Logging();
            }

            return _instance;
        }


        public void LogInfo(string msg)
        {
            _log.Info(msg);
        }
    }
}