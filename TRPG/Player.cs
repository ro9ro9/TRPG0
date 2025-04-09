namespace TRPG
{
    public class Player
    {
        private int curHP;
        public int CurHP { get { return curHP; } }

        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        public Inventory inventory;
        private bool gameOver;

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
            if (curHP == 0)
            {
                gameOver = true;
            }
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
