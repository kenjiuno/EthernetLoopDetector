using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EthernetLoopDetector.Utils
{
    internal class PerUnitCounter
    {
        private readonly TimeSpan maxSpan;
        private readonly List<Pair> pairList = new List<Pair>();

        class Pair
        {
            internal DateTime when;
            internal int value;
        }

        public PerUnitCounter(TimeSpan maxSpan)
        {
            this.maxSpan = maxSpan;
        }

        internal int Per()
        {
            var then = DateTime.Now.Subtract(maxSpan);
            pairList.RemoveAll(pair => pair.when < then);
            if (pairList.Any())
            {
                var lastValue = pairList.Last().value;
                var firstValue = pairList.First().value;

                return lastValue - firstValue;
            }
            return 0;
        }

        internal void Update(int value)
        {
            pairList.Add(new Pair { when = DateTime.Now, value = value });
        }
    }
}
