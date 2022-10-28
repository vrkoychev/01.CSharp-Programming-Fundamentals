using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }
    }
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input
                    .Split()
                    .ToArray();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box();
                box.Item = new Item();

                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = itemQuantity * itemPrice;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes.Sort((a, b) => (a.PriceForBox.CompareTo(b.PriceForBox)));
            boxes.Reverse();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}
