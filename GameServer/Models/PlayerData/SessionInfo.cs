﻿using NPTicket;
using System;

namespace GameServer.Models.PlayerData
{
    public class SessionInfo
    {
        public string Username => Authenticated ? Ticket.Username : "";
        public Presence Presence { get; set; } = Presence.OFFLINE;
        public DateTime ExpiryDate => Ticket.ExpiryDate.UtcDateTime;
        public Ticket Ticket { get; set; }
        public bool Authenticated => Ticket != null;
        public bool PolicyAccepted {  get; set; } = false;
        public DateTime LastPing { get; set; } = DateTime.UtcNow;
        public Platform Platform { get; set; }
        public bool IsMNR { get; set; }
        public int RandomSeed { get; set; }
    }
}
