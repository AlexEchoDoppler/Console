public class GameType
{
    public BattleSize GetBattleSize(int points)
    {
        switch (points)
        {
            default:
            case <= 500:
                return BattleSize.VerySmall;
            case > 500 and <= 1000:
                return BattleSize.Small;
            case > 1000 and <= 1500:
                return BattleSize.Medium;
            case > 1500 and <= 2000:
                return BattleSize.Standard;
        }
    }
}