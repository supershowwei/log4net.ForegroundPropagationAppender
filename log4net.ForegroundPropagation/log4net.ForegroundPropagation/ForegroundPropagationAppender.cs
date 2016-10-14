using System;
using log4net.Core;

namespace log4net.Appender
{
    public delegate void PropagationHandler(DateTime timeStamp, Level level, string message);

    public class ForegroundPropagationAppender : AppenderSkeleton
    {
        public PropagationHandler Propagation { private get; set; }

        protected override void Append(LoggingEvent loggingEvent)
        {
            
            if (this.Propagation != null)
            {
                this.Propagation(loggingEvent.TimeStamp, loggingEvent.Level, this.RenderLoggingEvent(loggingEvent));
            }
        }
    }
}