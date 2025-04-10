namespace TRPG.Items
{
    public class SeaShell : Item
    {
        public SeaShell()
        {
            string name = "조개 껍질";
            string description = "5개를 모으면 장신구를 만들 수 있습니다.";
        }
        public override void Use()
        {
            Console.WriteLine("예쁘기만 한 조개 껍질. 어딘가에 쓰일지도 모른다.");
        }
    }
}
