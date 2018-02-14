﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace VirtualInputController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new VirtualInputControllerService()
            };
            ServiceBase.Run(ServicesToRun);
            Logger logger = new Logger("VirtualInputController");
        }


    }
}
