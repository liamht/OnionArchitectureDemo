namespace OnionArchitectureDemo.DomainServices.Entities
{
    public class Car
    {
        public string Model { get; set; }

        public string Make { get; set; }

        public bool HasSpareWheel { get; set; }

        public double Price{ get; set; }

        //the concept here is that the business layer can be open to extension, without changing the data layer or the underlying entities, 
        //which may end up affecting the database
        public string CarName => $"{Make} {Model}";
    }
}
