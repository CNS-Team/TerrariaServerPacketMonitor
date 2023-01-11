﻿// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace TerrariaServerPacketMonitor
{
    internal class Packet
    {
        
        public string Name { get; init; } = null!;
        public PacketTypes Type { get; init; }
        public long Count { get; set; }
        public long TotalBytes { get; set; }
    }
    internal class Analyze
    {
        public long TotalPackets { get; set; }
        public long TotalBytes { get; set; }
        public long ReceivePackets { get; set; }
        public long ReceiveBytes { get; set; }
        public long SendPackets { get; set; }
        public long SendBytes { get; set; }
        public Packet[] Send { get; set; } = null!;
        public Packet[] Receive { get; set; } = null!;
    }
}
