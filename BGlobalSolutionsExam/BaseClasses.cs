namespace BGlobalSolutionsExam.Model
{
    public interface IIdEntity<T>
    {
        T Id { get; }
    }

    public interface IIntIdEntity : IIdEntity<int> { }

    public interface ISoftDeleteEntity
    {
        bool IsActive { get; set; }
    }

    public interface ISoftDeleteEntityAdd
    {
        bool IsActive { get; }
    }

}
