using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// API logging class
    /// </summary>
    public class WpfLogger : EventSource
    {
        /// <summary>
        /// Logging member
        /// </summary>
        public static readonly WpfLogger Log = new WpfLogger();

        /// <summary>
        /// Informational log handler
        /// </summary>
        /// <param name="message">informational message</param>
        [Event(1, Message = "{0}", Level = EventLevel.Informational)]
        public void Informational(string message)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(1, message);
            }
        }

        /// <summary>
        /// Error log handler
        /// </summary>
        /// <param name="message">error message</param>
        [Event(2, Message = "{0}", Level = EventLevel.Error)]
        public void Error(string message)
        {
            if (this.IsEnabled())
            {
                this.WriteEvent(2, message);
            }
        }
    }
}