using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class MessageDto
    {
        public string MessageType;
        public string Text;

        public MessageDto(string MessageType, string Text)
        {
            this.MessageType = MessageType;
            this.Text = Text;
        }
     
      
    }
}
