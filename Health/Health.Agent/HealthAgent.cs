using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Health.Agent
{
    public partial class HealthAgent : ServiceBase
    {
        private Handler handler;

        private TraceSource source = new TraceSource("Health");

        public HealthAgent()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                handler = new Handler();

                handler.Start();
            }
            catch(Exception ex)
            {
                source.TraceData(TraceEventType.Error, 0, ex);
            }
        }

        protected override void OnStop()
        {
            try
            {
                if (handler != null)
                    handler.Stop();
            }
            catch(Exception ex)
            {
                source.TraceData(TraceEventType.Error, 0, ex);
            }
        }
    }
}
