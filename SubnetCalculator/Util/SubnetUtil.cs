using SubnetCalculator.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SubnetCalculator.Util
{
    class SubnetUtil
    {
        private ObservableCollection<Solution> solutions = new ObservableCollection<Solution>();

        private readonly Dictionary<int, int> CidrHostsClassA = new Dictionary<int, int>()
        {
            {8, 16777216 },
            {9, 8388608 },
            {10, 4194304 },
            {11, 2097152 },
            {12, 1048576 },
            {13, 524288 },
            {14, 262144 },
            {15, 131072 },
            {16, 65536 },
            {17, 32768 },
            {18, 16384 },
            {19, 8192 },
            {20, 4096 },
            {21, 2048 },
            {22, 1024 },
            {23, 512 },
            {24, 256 },
            {25, 128 },
            {26, 64 },
            {27, 32 },
            {28, 16 },
            {29, 8 },
            {30, 4 }
        };

        private readonly Dictionary<int, int> CidrHostsClassB = new Dictionary<int, int>()
        {
            {16, 65536 },
            {17, 32768 },
            {18, 16384 },
            {19, 8192 },
            {20, 4096 },
            {21, 2048 },
            {22, 1024 },
            {23, 512 },
            {24, 256 },
            {25, 128 },
            {26, 64 },
            {27, 32 },
            {28, 16 },
            {29, 8 },
            {30, 4 }
        };

        private readonly Dictionary<int, int> CidrHostsClassC = new Dictionary<int, int>()
        {
            {24, 256 },
            {25, 128 },
            {26, 64 },
            {27, 32 },
            {28, 16 },
            {29, 8 },
            {30, 4 }
        };

        private readonly Dictionary<int, int> MaxSubnetsClassA = new Dictionary<int, int>()
        {
            {8, 1 },
            {9, 2 },
            {10, 4 },
            {11, 8 },
            {12, 16 },
            {13, 32 },
            {14, 64 },
            {15, 128 },
            {16, 256 },
            {17, 512 },
            {18, 1024 },
            {19, 2048 },
            {20, 4096 },
            {21, 8192 },
            {22, 16384 },
            {23, 32768 },
            {24, 65536 },
            {25, 131072 },
            {26, 262144 },
            {27, 524288 },
            {28, 1048576 },
            {29, 2097152 },
            {30, 4194304 }
        };

        private readonly Dictionary<int, int> MaxSubnetsClassB = new Dictionary<int, int>()
        {
            {16, 1 },
            {17, 2 },
            {18, 4 },
            {19, 8 },
            {20, 16 },
            {21, 32 },
            {22, 64 },
            {23, 128 },
            {24, 256 },
            {25, 512 },
            {26, 1024 },
            {27, 2048 },
            {28, 4096 },
            {29, 8192 },
            {30, 16384 }
        };

        private readonly Dictionary<int, int> MaxSubnetsClassC = new Dictionary<int, int>()
        {
            {24, 1 },
            {25, 2 },
            {26, 4 },
            {27, 8 },
            {28, 16 },
            {29, 32 },
            {30, 64 }
        };


        public int ConfigureCidrMaxHosts(int cidr, char IpClass)
        {
            if (IpClass == 'A')
            {
                if (CidrHostsClassA.ContainsKey(cidr))
                {
                    return CidrHostsClassA.GetValueOrDefault(cidr);
                }
            }

            if (IpClass == 'B')
            {
                if (CidrHostsClassB.ContainsKey(cidr))
                {
                    return CidrHostsClassB.GetValueOrDefault(cidr);
                }
            }

            if (IpClass == 'C')
            {
                if (CidrHostsClassC.ContainsKey(cidr))
                {
                    return CidrHostsClassC.GetValueOrDefault(cidr);
                }
            }

            return 0;
        }

        public int GetMaximumNumberOfSubnets(int cidr, char IpClass)
        {
            if (IpClass == 'A')
            {
                if (MaxSubnetsClassA.ContainsKey(cidr))
                {
                    return MaxSubnetsClassA.GetValueOrDefault(cidr);
                }
            }

            if (IpClass == 'B')
            {
                if (MaxSubnetsClassB.ContainsKey(cidr))
                {
                    return MaxSubnetsClassB.GetValueOrDefault(cidr);
                }
            }

            if (IpClass == 'C')
            {
                if (MaxSubnetsClassC.ContainsKey(cidr))
                {
                    return MaxSubnetsClassC.GetValueOrDefault(cidr);
                }
            }

            return 0;
        }

        public ObservableCollection<Solution> GetSolution(string ipAddress, int maxHosts, int maxSubnets)
        {
            string[] octets = ipAddress.Split(".");
            int octet = int.Parse(octets[3]);

            foreach (var item in Enumerable.Range(0, maxSubnets))
            {
                if (item == 0)
                {
                    this.solutions.Add(new Solution(octet, octet + 1, (octet + maxHosts -2), maxHosts -1));
                    continue;
                }

                this.solutions.Add(new Solution(maxHosts * item, (maxHosts * item) + 1, (maxHosts * item) + maxHosts - 2, (maxHosts * item) + maxHosts - 1));
            }

            return solutions;

        }

        public void SaveSolutionToFile()
        {

        }

    }
}
