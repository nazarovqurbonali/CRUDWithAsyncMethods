namespace Domain.Models;

public class Mentor
{
    public int Id { get; set; }
    public required string Fullname { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
}