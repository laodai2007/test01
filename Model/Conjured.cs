using System;
using System.Collections.Generic;
using System.Text;

namespace NFQ_Kata
{
    public class Conjured : Item
    {
        public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        /// <summary>
        /// Conjured" items degrade in Quality twice as fast as normal items
        /// </summary>
        public override void UpdateQuality()
        {
            if (SellIn < 0)
                Quality -= 4;
            Quality -= 2;
            base.UpdateQuality();
        }
    }
}
