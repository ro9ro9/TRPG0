namespace TRPG.Items
{
    public class RabbitMeat : Item
    {
        public RabbitMeat()
        {
            string name = "토끼 고기";
            string description = "맛있어 보이는 토끼 고기, 체력을 25 회복합니다.";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 25 회복합니다.");
            Game.Player.Heal(25);
        }
    }
}

