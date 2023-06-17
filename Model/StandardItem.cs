using System;
using System.Collections.Generic;
using System.Text;

namespace NFQ_Kata
{
    public class StandardItem : Item
    {
        public StandardItem(string name, int sellIn, int quality) 
            : base(name, sellIn, quality) { }

        /// <summary>
        /// Once the sell-by date has passed, Quality degrades twice as fast
        /// </summary>
        public override void UpdateQuality()
        {
            if (SellIn < 0)
                Quality -= 2;
            Quality -= 1;
            base.UpdateQuality();
        }
    }
}
