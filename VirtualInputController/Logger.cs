#region Namespaces
using NLog;
using NLog.Targets;
using NLog.Config;
#endregion

namespace VirtualInputController
{
    public class Logger
    {
        public Logger(string logName, bool consoleLoggingOn = false)
        {
            _logName = logName;
            _consoleLoggingOn = consoleLoggingOn;
            Initialize();
        }

        #region Private Methods
        //
        private void Initialize()
        {
            SetFileTarget();
            SetLoggingRules();
            CreateConfig();
        }

        private void CreateConfig()
        {
            _config = new LoggingConfiguration();
            _config.AddTarget("file", _fileTarget);
            _config.LoggingRules.Add(_rule);
            LogManager.Configuration = _config;
        }

        private void SetFileTarget()
        {
            _fileTarget = new FileTarget();
            _fileTarget.FileName = "${basedir}/" + _logName + ".log";
            _fileTarget.Layout = @"[${date:format=HH\:mm\:ss}::${logger}::${threadid}] ${message}";
        }

        private void SetLoggingRules()
        {
            _rule = new LoggingRule("*", LogLevel.Trace, _fileTarget);
        }
        //
        #endregion

        #region Declarations
        //
        private string _logName;
        private bool _consoleLoggingOn;

        private LoggingConfiguration _config;
        private FileTarget _fileTarget;
        private LoggingRule _rule;
        //
        #endregion
    }
}
