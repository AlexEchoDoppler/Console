namespace Test
{
#nullable enable
    public class ArmyList
    {
        public string? name;
        public List<Figurine> figurines = new List<Figurine>();
        public GameType gameType = new GameType();
        public Army? army;

        public int points => GetAllPointsFromFigurines();
        public BattleSize battleSize => gameType.GetBattleSize(points);

        public ArmyList(string? name, Army army)
        {
            this.name = name;
            this.army = army;
        }

        public int GetAllPointsFromFigurines()
        {
            var points = 0;

            foreach (var figurine in figurines)
                points += figurine.points;

            return points;
        }

        public void GetInfo()
        {

            if (army != null)
                Console.WriteLine($"Ma liste d'armée s'appelle {name}, c'est une armée {army.armyName}, de {points} points, elle se joue dans la tranche {battleSize}");

            foreach (var fig in figurines)
                Console.WriteLine($"On a {fig.name} comme unitée dans la liste.");
        }

        // public static bool ACompareWithB(ArmyList firstArmy, ArmyList secondArmy)
        // {
        //     if (firstArmy.gameType != null && secondArmy.gameType != null)
        //     {
        //         if (firstArmy.gameType.battleSize == secondArmy.gameType.battleSize)
        //         {
        //             Console.WriteLine($"L'armée {firstArmy.name} et l'armée {secondArmy.name} ont la même tranche de valeur d'armée {firstArmy.gameType.battleSize}.");
        //             return true;
        //         }
        //         else
        //             Console.WriteLine($"L'armée {firstArmy.name} et l'armée {secondArmy.name} n'ont pas la même tranche de valeur d'armée. Mon armée a {firstArmy.points} points contre {secondArmy.points} points.");

        //     }
        //     return false;
        // }

        // public static void ListACompareWithListB(ArmyList[] firstListArmy, ArmyList[] secondListArmy)
        // {
        //     for (int i = 0; i < 4; i++)
        //     {
        //         foreach (var myArmy in firstListArmy)
        //         {
        //             foreach (var opponmentArmy in secondListArmy)
        //             {
        //                 if (myArmy.gameType != null && opponmentArmy.gameType != null)
        //                 {

        //                     if ((int)myArmy.gameType.battleSize == i && myArmy.gameType.battleSize == opponmentArmy.gameType.battleSize)
        //                     {
        //                         Console.WriteLine($"Ma liste d'armée {myArmy.name} peut jouer avec l'armée {opponmentArmy.name} de mon adversaire dans le mode {myArmy.gameType.battleSize}");
        //                     }
        //                 }
        //             }
        //         }
        //         Console.WriteLine("------------------------------------------------------------------");
        //     }
        // }
    }
}