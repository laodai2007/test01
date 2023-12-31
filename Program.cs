﻿using System;
using System.Collections.Generic;

namespace NFQ_Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>
            {
                ItemFactory.CreateItem("+5 Dexterity Vest", 10, 20),
                ItemFactory.CreateItem("Aged Brie", 2, 0),
                ItemFactory.CreateItem("Elixir of the Mongoose", 5, 7),
                ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", 0, 80),
                ItemFactory.CreateItem("Sulfuras, Hand of Ragnaros", -1, 80),
                ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                ItemFactory.CreateItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                ItemFactory.CreateItem("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(Items);

            int daysCheck = 31;
            for (var i = 0; i < daysCheck; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("Name, SellIn, quality");
                foreach (var item in Items)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
            Console.ReadLine();
        }
    }
}

