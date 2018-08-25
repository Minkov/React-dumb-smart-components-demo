using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoApp.Models.Abstracts;

namespace TodoApp.Models
{
    public class Todo : IDeletable, IAudiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [Required]
        public TodoState TodoState { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}