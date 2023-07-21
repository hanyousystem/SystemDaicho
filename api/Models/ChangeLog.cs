using System.ComponentModel.DataAnnotations;
public class ChangeLog
{
    public string? UserID { get; set; }
    public string? Section { get; set; }
     [Key]
    public string? DateTime { get; set; }
    public string? Operation { get; set; }
}