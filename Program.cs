using Test;

public static class Program
{
    public delegate void MethodShowAllArmyList(int count);

    public static Army Khorne = new Army(ArmyName.Khorne, Alignment.Chaos);
    public static Army Skaven = new Army(ArmyName.Skaven, Alignment.Chaos);

    public static Figurine fig1 = new Figurine("fig1", Khorne, 140);
    public static Figurine fig2 = new Figurine("fig2", Khorne, 180);
    public static Figurine fig3 = new Figurine("fig3", Khorne, 720);
    public static Figurine fig4 = new Figurine("fig4", Khorne, 70);
    public static Figurine fig5 = new Figurine("fig5", Khorne, 85);
    public static Figurine fig6 = new Figurine("fig6", Khorne, 435);
    public static Figurine fig7 = new Figurine("fig7", Khorne, 110);
    public static Figurine fig8 = new Figurine("fig8", Khorne, 185);
    public static Figurine fig9 = new Figurine("fig9", Khorne, 330);
    public static Figurine fig10 = new Figurine("fig10", Khorne, 200);

    public static ArmyList armyList1 = new ArmyList("List1", Khorne);

    public static void Main()
    {
        // ExecuteManyTimes(ArmyListList.Length, (index) =>
        //  { 
        //     ArmyListList[index].GetInfo(ArmyListList[index].name,ArmyListList[index].alignmentId);
        //  });
        //  ArmyList.AHasMoreArmyListValueFromB(ArmyListList[0],ArmyListList[1]);

        armyList1.figurines.Add(fig1);
        armyList1.figurines.Add(fig1);
        armyList1.figurines.Add(fig1);
        armyList1.figurines.Add(fig1);
        armyList1.figurines.Add(fig1);

        armyList1.GetInfo();
    }

    public static void ExecuteManyTimes(int count, MethodShowAllArmyList method)
    {
        for (int i = 0; i < count; i++)
        {
            method(i);
        }
    }
}
