namespace WebApplication1.Models
{
    public interface IClient
    {
        int Id { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
    }
}