﻿namespace ElmCommunicator.Commands.ElmCommands
{
    public class WarmStartSendMessage : SendMessage
    {
        public WarmStartSendMessage()
        {
            Command = "AT WS";
        }
    }
}