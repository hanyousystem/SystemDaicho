using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class ChangeLog
{
    public string? UserID { get; set; }
    public string? Section { get; set; }
    [Key]
    public DateTime? DateTime { get; set; }
}