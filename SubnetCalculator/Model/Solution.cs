using System;
using System.Collections.Generic;
using System.Text;

namespace SubnetCalculator.Model
{
    class Solution
    {
        public int NetworkAddress { get; set; }
        public int FirstUsableAddress { get; set; }
        public int LastUsableAddress { get; set; }
        public int BroadcastAddress { get; set; }

        public Solution()
        {

        }

        public Solution(int netAddr, int firstUsableAddr, int lastUsableAddr, int broadcastAddr)
        {
            this.NetworkAddress = netAddr;
            this.FirstUsableAddress = firstUsableAddr;
            this.LastUsableAddress = lastUsableAddr;
            this.BroadcastAddress = broadcastAddr;
        }
    }
}
