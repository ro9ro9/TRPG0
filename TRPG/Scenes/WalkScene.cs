namespace TRPG.Scenes
{
    public class WalkScene : Scene
    {
        public override void Choice()
        {

        }

        public override void Render()
        {
            Console.WriteLine("주변을 둘러봅니다");
            Console.WriteLine("아무키나 눌러주세요.");
            Console.ReadKey(true);
        }

        Random random = new Random();
        public override void Result()
        {
            int randomValue = random.Next(0, 100);
            if (randomValue <= 5)
            {
                Console.WriteLine("무언가 발견했습니다!");
                Console.WriteLine("축하드립니다! 건강식 통조림을 얻었습니다!");
                //Player.Inventory.Add("건강식 통조림");
            }
            else if (randomValue <= 20)
            {
                Console.WriteLine("무언가를 발견했습니다!");
                Console.WriteLine("조개 껍질을 발견했습니다!");
                //Player.Inventory.Add("조개 껍질");
            }
            else { Console.WriteLine("아무것도 발견하지 못했습니다..."); }
            Console.WriteLine("거점으로 돌아갑니다.");
            Game.LoadScene("Town");
        }

        public override void Wait()
        {
            
        }
        public override void Next()
        {

        }
    }
}
