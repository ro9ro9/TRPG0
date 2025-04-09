namespace TRPG.Enemys
{
    public class MapDamage : Damages
    {
        public override void Damage()
        {
            Game.Player.GetDamage(5);
        }
    }
}
