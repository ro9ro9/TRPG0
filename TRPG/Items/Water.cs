namespace TRPG.Items
{
    internal class Water : Item
    {
        public Water()
        {
            string name = "물";
        }
        public override void Use()
        {
            Game.Player.Heal(15);
        }
    }
}
