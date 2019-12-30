﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }


        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
