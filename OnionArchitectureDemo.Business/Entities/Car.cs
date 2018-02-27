namespace OnionArchitectureDemo.Business.Entities
{
    public class Car
    {
        public string Model { get; set; }

        public string Make { get; set; }

        public bool HasSpareWheel { get; set; }

        public string CarName => $"{Model} {Make}";
    }
}
