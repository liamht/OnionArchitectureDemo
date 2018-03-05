namespace OnionArchitectureDemo.ApplicationServices.Cars.Queries.GetCarDetails
{
    public interface IGetCarDetailsQuery
    {
        CarDetailsModel Execute(int carListingId);
    }
}