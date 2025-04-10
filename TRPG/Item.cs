namespace TRPG
{
    public abstract class Item
    {
        public string name;
        public string description;
       // public void Interact(Player player)
       // {
       //     player.Inventory.Add(this);
       // }

        public abstract void Use();
    }
}