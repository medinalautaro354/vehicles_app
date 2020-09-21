namespace BGlobalSolutionsExam.Model.Entities
{
    public enum Brand
    {
        Fiat, Peugeot, Audi
    }

    public interface IVehicle : IIntIdEntity, ISoftDeleteEntity
    {
        string LicensePlate { get; }
        Brand Brand { get; }
        int NumberOfDoors { get; }
        string Owner { get; }
    }

}
