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
            Console.WriteLine("체력을 15 회복합니다.");
            Game.Player.Heal(15);
        }
    }
}
