using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Health.Diagnostics
{
    /// <summary>
    /// Represents a Trace Start/Stop where the Start and Stop are called automatically
    /// </summary>;
    public class TraceLogicalScope : IDisposable
    {
        /// <summary>
        /// The source that we are tracing through as part of this scope
        /// </summary>
        private readonly TraceSource source;

        /// <summary>
        /// The name of the logical block that this scope represents
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Constructor used to initialize the class
        /// </summary>
        /// <param name="source">The source that we are tracing through as part of this scope</param>
        /// <param name="name">The name of the logical block that this scope represents</param>
        public TraceLogicalScope(TraceSource source, string name)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            this.source = source;
            this.name = name;

            this.source.TraceEvent(TraceEventType.Start, 0, String.Format("Starting {0}", name));
        }

        /// <summary>
        /// Called when the object is cleaned up, to close the scope
        /// </summary>
        public void Dispose()
        {
            this.source.TraceEvent(TraceEventType.Stop, 0, String.Format("Stopping {0}", this.name));
        }
    }
}
