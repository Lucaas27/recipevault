namespace recipevault.API.Interfaces
{
    public interface ITimestampable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}