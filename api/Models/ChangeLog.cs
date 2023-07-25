using System.ComponentModel.DataAnnotations;
public class ChangeLog
{
    public string? UserID { get; set; }
    public string? Section { get; set; }
    [Key]
    public string? DateTime { get; set; }
    public string? Operation { get; set; }
    public string? DaichoType { get; set; }
    public string? DataID { get; set; }
    public string? UpdateItemName { get; set; }
    public string? UpdateBefore { get; set; }
    public string? UpdateAfter { get; set; }
}