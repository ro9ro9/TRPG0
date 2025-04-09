namespace TRPG
{
    public abstract class Item
    {

        public void Interact(Player player)
        {
            player.inventory.Add(this);
        }

        public abstract void Use();
    }
}