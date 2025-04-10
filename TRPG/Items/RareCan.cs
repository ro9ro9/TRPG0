namespace TRPG.Items
{
    public class RareCan : Item
    {
        public RareCan()
        {
            string name = "건강식 통조림";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 40 회복합니다.");
            Game.Player.Heal(40);
        }
    }
}
