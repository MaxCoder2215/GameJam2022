using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam2022Server
{
    public class ServerMessage
    {
        public OpCode MessageType { get; set; }

        public int Player { get; set; }

        public string Message { get; set; }

        public ServerMessage(OpCode messageType, int player, string jsonMessage)
        {
            MessageType = messageType;
            this.Player = player;
            Message = jsonMessage;
        }
        public enum OpCode
        {
            ITEM,
            EVENT,
            PlayerJoin
        }
    }
}
