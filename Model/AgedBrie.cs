using System;
using System.Collections.Generic;
using System.Text;

namespace NFQ_Kata
{
    public class AgedBrie : Item
    {
        public AgedBrie(string name, int sellIn, int quality) 
            : base(name, sellIn, quality)
        {
        }
        /// <summary>
        /// "Aged Brie" actually increases in Quality the older it gets
        /// </summary>
        public override void UpdateQuality()
        {
            Quality += 1;
            base.UpdateQuality();
        }
    }
}
