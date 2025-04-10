namespace TRPG.Items
{
    internal class Seashell : Item
    {
        public Seashell()
        {
            string name = "조개 껍질";
        }
        public override void Use()
        {
            Console.WriteLine("예쁘기만 한 조개 껍질. 어딘가에 쓰일지도 모른다.");
        }
    }
}
