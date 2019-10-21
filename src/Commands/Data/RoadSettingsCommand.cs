﻿using ProtoBuf;

namespace CSM.Commands
{
    [ProtoContract]
    public class RoadSettingsCommand : CommandBase
    {
        [ProtoMember(1)]
        public ushort NodeID { get; set; }
        
        [ProtoMember(2)]
        public int Index { get; set; }
    }
}