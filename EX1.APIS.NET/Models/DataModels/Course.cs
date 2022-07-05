using System.ComponentModel.DataAnnotations;



namespace EX1.APIS.NET.Models.DataModels
{
    public enum Level
    {
        Basic,
        Intermediate,
        Advanced
    }
    public class Course : BaseEntity
    {
        [Required]
        public string CourseName { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDesc { get; set; } = string.Empty;

        [Required]
        public string LongDesc { get; set; } = string.Empty;

        [Required]
        public string ObjPublic { get; set; } = string.Empty;

        [Required]
        public string Objectives { get; set; } = string.Empty;

        [Required]
        public string Requisites { get; set; } = string.Empty;

        [Required]
        public Level Level { get; set; } = Level.Basic;
    }
}
