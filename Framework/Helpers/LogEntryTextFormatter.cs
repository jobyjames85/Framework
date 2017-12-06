using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// Formatter for log entries
    /// </summary>
    public class LogEntryTextFormatter : IEventTextFormatter
    {
        #region Constants
        /// <summary>
        /// The provider ID
        /// </summary>
        internal const string ProviderId = "ProviderId";

        /// <summary>
        /// The event ID
        /// </summary>
        internal const string EventId = "EventId";

        /// <summary>
        /// The keywords
        /// </summary>
        internal const string Keywords = "Keywords";

        /// <summary>
        /// The level
        /// </summary>
        internal const string Level = "Level";

        /// <summary>
        /// The message
        /// </summary>
        internal const string Message = "Message";

        /// <summary>
        /// The Operation Code
        /// </summary>
        internal const string Opcode = "Opcode";

        /// <summary>
        /// The task
        /// </summary>
        internal const string Task = "Task";

        /// <summary>
        /// The version
        /// </summary>
        internal const string Version = "Version";

        /// <summary>
        /// The payload
        /// </summary>
        internal const string Payload = "Payload";

        /// <summary>
        /// The event name
        /// </summary>
        internal const string EventName = "EventName";

        /// <summary>
        /// The time stamp
        /// </summary>
        internal const string Timestamp = "Timestamp";
        #endregion

        #region Private Members
        /// <summary>
        /// Gets or sets the date time format of log entry
        /// </summary>
        private string dateTimeFormat;

        /// <summary>
        /// Gets or sets the header
        /// </summary>
        private string header;

        /// <summary>
        /// Gets or sets the footer
        /// </summary>
        private string footer;

        /// <summary>
        /// Gets or sets the verbosity threshold
        /// </summary>
        private EventLevel verbosityThreshold;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntryTextFormatter" /> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="footer">The footer.</param>
        /// <param name="verbosityThreshold">The verbosity threshold.</param>
        /// <param name="dateTimeFormat">The date time format used for timestamp value.</param>
        public LogEntryTextFormatter(string header = null, string footer = null, EventLevel verbosityThreshold = EventTextFormatter.DefaultVerbosityThreshold, string dateTimeFormat = null)
        {
            this.header = header;
            this.footer = footer;
            this.verbosityThreshold = verbosityThreshold;
            this.dateTimeFormat = dateTimeFormat;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Writes the event to log file
        /// </summary>
        /// <param name="eventEntry">the event entry</param>
        /// <param name="writer">the writer</param>
        public void WriteEvent(EventEntry eventEntry, TextWriter writer)
        {
            // Write header
            if (!string.IsNullOrWhiteSpace(this.header))
            {
                writer.WriteLine(this.header);
            }

            if (eventEntry.Schema.Level <= this.verbosityThreshold || this.verbosityThreshold == EventLevel.LogAlways)
            {
                string format = "{0} : {1}";

                // Write with verbosityThreshold format 
                writer.WriteLine(format, Timestamp, this.GetFormattedTimestamp(eventEntry.Timestamp.ToLocalTime(), this.dateTimeFormat));
                writer.WriteLine(format, ProviderId, eventEntry.ProviderId);
                writer.WriteLine(format, EventId, eventEntry.EventId);
                writer.WriteLine(format, Keywords, eventEntry.Schema.Keywords);
                writer.WriteLine(format, Level, eventEntry.Schema.Level);
                writer.WriteLine(format, Message, eventEntry.FormattedMessage);
                writer.WriteLine(format, Opcode, eventEntry.Schema.Opcode);
                writer.WriteLine(format, Task, eventEntry.Schema.Task);
                writer.WriteLine(format, Version, eventEntry.Schema.Version);
                writer.WriteLine(format, EventName, eventEntry.Schema.EventName);
            }
            else
            {
                // Write with summary format
                writer.WriteLine(
                    "{0} : {1}, {2} : {3}, {4} : {5}, {6} : {7}, {8} : {9}",
                    EventId,
                    eventEntry.EventId,
                    Level,
                    eventEntry.Schema.Level,
                    Message,
                    eventEntry.FormattedMessage,
                    EventName,
                    eventEntry.Schema.EventName,
                    Timestamp,
                    this.GetFormattedTimestamp(eventEntry.Timestamp.ToLocalTime(), this.dateTimeFormat));
            }

            // Write footer
            if (!string.IsNullOrWhiteSpace(this.footer))
            {
                writer.WriteLine(this.footer);
            }

            writer.WriteLine();
        }

        /// <summary>
        /// Gets the formatted timestamp.
        /// </summary>
        /// <param name="timestamp">the timestamp</param>
        /// <param name="format">The format.</param>
        /// <returns>The formatted string.</returns>
        public string GetFormattedTimestamp(DateTimeOffset timestamp, string format)
        {
            return timestamp.ToString(string.IsNullOrWhiteSpace(format) ? "O" : format, CultureInfo.InvariantCulture);
        }
        #endregion
    }
}

