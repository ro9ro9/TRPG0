namespace TRPG
{
    public class Player
    {
        private int curHP;
        public int CurHP { get { return curHP; } }

        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Inventory inventory;



        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            // curHP = maxHP;
            curHP = 100;
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }

        public void GetDamage(int damage)
        {
            curHP -= damage;
        }
    }
}
