﻿namespace DataLayer.Persistence.Message
{
    using System;

    using Domain.Message;

    public class MessageFactory
    {
        public Message Create(Guid id, Guid senderPersonId, Guid receiverPersonId, string text, DateTime sendingDate)
        {
            return new Message { Id = id, SenderPersonId = senderPersonId, ReceiverPersonId = receiverPersonId, Text = text, IsRead = false, SendingDate = sendingDate };
        }
    }
}
