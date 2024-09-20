namespace Pets.Entities
{
    public class Food : Product
    {
        // extra properties enkel voor Food
        public double Weight { get; set; }
        // AgeCategory is een enum
        public AgeCategory AgeCategory { get; set; }

        public Food()
        {
            
        }
    }
}
