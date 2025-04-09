using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG
{
    public class Inventory : List<Item>
    {
        private List<Item> items;
        private Stack<string> stack;
        private int selectIndex;

        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public void UseAt(int index)
        {
            items[index].Use();
        }
    }
}
