namespace TodoApp.Models.Abstracts
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
    }
}