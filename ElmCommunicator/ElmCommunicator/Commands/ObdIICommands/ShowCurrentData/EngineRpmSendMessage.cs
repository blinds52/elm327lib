﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmCommunicator.Commands.ObdIICommands.ShowCurrentData
{
    public class EngineRpmSendMessage : SendMessage
    {
        public EngineRpmSendMessage()
        {
            this.Command = "01";
            this.Data = "0C";
        }
    }
}
