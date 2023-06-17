using System;
using System.Collections.Generic;
using System.Text;

namespace NFQ_Kata
{
    public class Sulfuras : Item
    {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        /// <summary>
        /// Being a legendary item, never has to be sold 
        /// </summary>
        public override void UpdateSellIn()
        {
        }

        /// <summary>
        ///  "Sulfuras" is a legendary item, and as such its Quality is 80 and it never alters.
        /// </summary>
        public override void UpdateQuality()
        {
            //Set Quality is 80 if users input have problem
            Quality = 80;
        }
    }
}
