using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace VirtualInputController
{
    public partial class VirtualInputController : ServiceBase
    {
        public VirtualInputController()
        {
            InitializeComponent();
            InitEventLog();
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("VirtualInputConroller Service Started");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("VirtualInputConroller Service Stopped");
        }

        private void InitEventLog()
        {
            eventLog1 = new EventLog();
            if (!EventLog.SourceExists("VirtualInputController"))
            {
                EventLog.CreateEventSource("VirtualInputController", "Application");
            }

            eventLog1.Source = "VirtualInputController";
            eventLog1.Log = "Application";
        }
    }
}
