using System.ComponentModel.DataAnnotations.Schema;

public class Student {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public int ClassId { get; set; }
}