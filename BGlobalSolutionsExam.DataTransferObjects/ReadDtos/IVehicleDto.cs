namespace BGlobalSolutionsExam.DataTransferObjects.ReadDtos
{
    public interface IVehicleDto 
    {
        int Id { get; }
        string LicensePlate { get; }
        string Brand { get; }
        int BrandId { get; }
        int NumberOfDoors { get; }
        string Owner { get; }
        bool IsActive { get; }
    }
}
