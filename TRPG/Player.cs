namespace TRPG
{
    public class Player
    {
        private int curHP;
        public int CurHP
        {
            get { return curHP; }
            set
            {
                if (curHP > 0 && curHP <= 100)
                {
                    curHP = value;
                }
            }
        }
        private int maxHP;
        public int MaxHP { get { return maxHP; } }



        public Player()
        {
            // inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }
    }
}
