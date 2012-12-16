using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using SD.ConnectwiseApi.Config;
using System.Configuration;

namespace SD.ConnectwiseApi.Util
{
    public sealed class Logger
    {
        private bool _isEnabled = false;
        private readonly TraceSource source;
        public Logger(bool autoflush = false)
        {
            var config = (ConnectwiseConfigSection)ConfigurationManager.GetSection("connectwise");
            if (config.Logging != null)
            {
                if (!string.IsNullOrWhiteSpace(config.Logging.SourceName))
                {
                    try
                    {
                        source = new TraceSource(config.Logging.SourceName);
                        this._isEnabled = true;
                        this.AutoFlush = autoflush;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
        }

        public bool AutoFlush { get; set; }

        public void Write(string message)
        {
            if (!IsEnabled) return;
            source.TraceEvent(TraceEventType.Information, 0, message);
            if (this.AutoFlush) source.Flush();
        }

        public void Write(string format, params object[] args)
        {
            if (!IsEnabled) return;
            source.TraceEvent(TraceEventType.Information, 0, format, args);
            if (this.AutoFlush) source.Flush();
        }

        public void Flush()
        {
            if (!IsEnabled) return;
            if (!this.AutoFlush) source.Flush();
        }
    }
}
