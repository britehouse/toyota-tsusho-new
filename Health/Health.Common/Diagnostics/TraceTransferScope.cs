using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Health.Diagnostics
{
    // <summary>
    /// Represents a Trace Transfer scope within which tracing Transfers to and from another Activity
    /// </summary>
    public class TraceTransferScope : IDisposable
    {
        /// <summary>
        /// The activity ID that we stitched away from when this scope was started
        /// </summary>
        private readonly Guid oldActivity;

        /// <summary>
        /// The activity ID that we stitched to when this scope was started
        /// </summary>
        private readonly Guid newActivity;

        /// <summary>
        /// The source that we are tracing through as part of this scope
        /// </summary>
        private readonly TraceSource source;

        /// <summary>
        /// The name of the activity that this scope represents
        /// </summary>
        private readonly string name;

        /// <summary>
        /// Constructor used to initialize the class
        /// </summary>
        /// <param name="source">The source that we are tracing through as part of this scope</param>
        /// <param name="name">The name of the activity that this scope represents</param>
        public TraceTransferScope(TraceSource source, string name)
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
            this.oldActivity = Trace.CorrelationManager.ActivityId;
            this.name = name;

            this.newActivity = Guid.NewGuid();

            if (this.oldActivity != Guid.Empty)
            {
                this.source.TraceTransfer(0, string.Format("Transferring to {0}...", this.name), this.newActivity);
            }

            Trace.CorrelationManager.ActivityId = this.newActivity;

            this.source.TraceEvent(TraceEventType.Start, 0, this.name);
        }

        /// <summary>
        /// Called when the object is cleaned up, to close the scope
        /// </summary>
        public void Dispose()
        {
            if (this.oldActivity != Guid.Empty)
            {
                this.source.TraceTransfer(0, string.Format("Transferring back from {0}...", this.name), this.oldActivity);
            }

            this.source.TraceEvent(TraceEventType.Stop, 0, this.name);

            Trace.CorrelationManager.ActivityId = this.oldActivity;
        }
    }
}
