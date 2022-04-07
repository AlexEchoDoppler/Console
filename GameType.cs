public class GameType
{
    public BattleSize battleSize;

    public BattleSize GetBattleSize(int points)
    {
        switch(points)
        {
            case <=500:
            battleSize = BattleSize.VerySmall;
            break;
            case >500 and <=1000:
            battleSize = BattleSize.Small;
            break;
            case >1000 and <=1500:
            battleSize = BattleSize.Medium;
            break;
            case >1500 and <=2000:
            battleSize = BattleSize.Standard;
            break;
        }
        return battleSize;
    }
} 