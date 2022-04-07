namespace Test
{
    #nullable enable
    public class Figurine 
    {
        public string? name;
        public Army? army;
        public int points;
        
        public Figurine(string? name,Army? army,int points)
        {
            this.name = name;
            this.army = army;
            this.points = points;       
        }
    }
}