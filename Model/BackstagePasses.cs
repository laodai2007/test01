using System;
using System.Collections.Generic;

namespace NFQ_Kata
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        /// <summary>
        /// "Backstage passes", like aged brie, increase in Quality as its SellIn value approaches;Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concer
        /// </summary>
        public override void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
            {
                Quality += 2;
            }
            else
            {
                Quality += 1;
            }
            base.UpdateQuality();
        }
    }
}
