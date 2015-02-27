﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Commands;
using UnitsNet;

namespace ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData
{
    public class BarometricPressureResponse : ResponseMessage
    {
        public override IReceiveMessage Parse(string message)
        {
            this.Command = this.GetCommand(ref message);
            this.Data = message.Substring(4);
            this.Pressure = Pressure.FromKilopascals(this.HexToDec(this.Data));

            return this;
        }

        public Pressure Pressure { get; private set; }
    }
}