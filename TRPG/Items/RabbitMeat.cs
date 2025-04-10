namespace TRPG.Items
{
    internal class RabbitMeat : Item
    {
        public RabbitMeat() { string name = "토끼 고기"; }
        public override void Use()
        {
            Console.WriteLine("체력을 25 회복합니다.");
            Game.Player.Heal(25);
        }
    }
}

