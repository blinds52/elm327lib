﻿namespace ElmCommunicator.Commands.ElmCommands
{
    public class NormalLengthMessagesSendMessage : SendMessage
    {
        public NormalLengthMessagesSendMessage()
        {
            Command = "AT NL";
        }
    }
}