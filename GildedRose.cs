using System.Collections.Generic;

namespace NFQ_Kata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateSellIn();
                item.UpdateQuality();
            }
        }
    }
}
