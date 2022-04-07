namespace Test
{
    #nullable enable
    public class ArmyList
    {
        public string? name {get;set;} 
        public GameType? gameType {get => GetBattleSize(points);}
        public int points {get => GetAllPoints();} 
        public Army? Army {get;set;} 
        public List<Figurine>? figurines {get;set;} 

        public ArmyList(string? name, List<Figurine>? figurines)
        {
            this.name = name;
            this.figurines = figurines;
        }

        public int GetAllPoints()
        {
            var _a = 0;
            if (figurines != null)
            {
                foreach (var figurine in figurines)
                {
                    _a += figurine.points;
                }           
            }
            return _a;
        }

        public GameType GetBattleSize(int point){
            if (gameType != null) 
            {
                gameType.GetBattleSize(points);
                return gameType;
            }
            else
                return new GameType();
        }
        public void GetInfo()
        {   
            //GetAllPoints();
            if(Army != null && gameType != null)
                Console.WriteLine($"Ma liste d'armée s'appelle {name}, c'est une armée {Army.armyName}, de {points} points, elle se joue dans la tranche {gameType.battleSize}");
            if(figurines != null)
            {
                foreach (var fig in figurines)
                {
                    Console.WriteLine($"On a {fig.name} comme unitée dans la liste.");       
                }
           }
        }

        public static bool ACompareWithB (ArmyList firstArmy, ArmyList secondArmy)
        {
            if (firstArmy.gameType != null && secondArmy.gameType != null)
            {
                if (firstArmy.gameType.battleSize == secondArmy.gameType.battleSize)
                {
                    Console.WriteLine($"L'armée {firstArmy.name} et l'armée {secondArmy.name} ont la même tranche de valeur d'armée {firstArmy.gameType.battleSize}.");
                    return true;
                }
                else
                    Console.WriteLine($"L'armée {firstArmy.name} et l'armée {secondArmy.name} n'ont pas la même tranche de valeur d'armée. Mon armée a {firstArmy.points} points contre {secondArmy.points} points.");

            }
            return false;
        }

        public static void ListACompareWithListB(ArmyList[] firstListArmy, ArmyList[] secondListArmy)
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (var myArmy in firstListArmy)
                {
                    foreach (var opponmentArmy in secondListArmy)
                    {
                        if (myArmy.gameType != null && opponmentArmy.gameType != null)
                            {

                            if((int)myArmy.gameType.battleSize == i && myArmy.gameType.battleSize == opponmentArmy.gameType.battleSize)
                            {
                                Console.WriteLine($"Ma liste d'armée {myArmy.name} peut jouer avec l'armée {opponmentArmy.name} de mon adversaire dans le mode {myArmy.gameType.battleSize}");
                            }
                        }
                    }
                }
            Console.WriteLine("------------------------------------------------------------------");
            }
        }
    }
}