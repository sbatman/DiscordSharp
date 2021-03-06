﻿using Newtonsoft.Json.Linq;

namespace DiscordSharp
{
    public enum DiscordUserStatus { ONLINE, IDLE, OFFLINE }

    public class DiscordPresenceUpdateEventArgs
    {
        public DiscordMember user { get; internal set; }
        public DiscordUserStatus status { get; internal set; }
        public int? game_id { get; internal set; }

        public JObject RawJson { get; internal set; }
    }
}