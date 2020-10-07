using System;
using System.Collections.Generic;
using System.Text;

namespace HolyPlugy
{
    public class Inventory
    {
        private List<Item> items;
        private int endIndex;

        public Inventory()
        {
            setItems(new List<Item>());
        }

        public Inventory(List<Item> items)
        {
            setItems(items);
        }

        public List<Item> getItems()
        {
            return items;
        }

        public void setItems(List<Item> items)
        {
            this.items = items;
        }

        public int getEndIndex()
        {
            return endIndex;
        }

        public void setEndIndex(int endIndex)
        {
            this.endIndex = endIndex;
        }
	}
}
