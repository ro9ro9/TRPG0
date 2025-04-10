namespace TRPG.Enemys
{
    public class MapDamage : Damages
    {
      // public override void DamageName()
      // {
      //     string mapDamage;
      // }
        public override void Damage()
        {
            Game.Player.GetDamage(5);
        }
    }
}
