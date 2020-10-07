using System;
using System.Collections.Generic;
using System.Text;

namespace HolyPlugy
{
    class Stash : Inventory
    {
        private int height;
        private int width;
        private bool shared;

        public Stash()
        {
            
        }

        public Stash(List<Item> items) : base(items)
        {
            
        }

        public int getHeight()
        {
            return height;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public int getWidth()
        {
            return width;
        }
        public void setWidth(int width)
        {
            this.width = width;
        }

        public bool isShared()
        {
            return shared;
        }

        public void setShared(bool shared)
        {
            this.shared = shared;
        }
	}
}
