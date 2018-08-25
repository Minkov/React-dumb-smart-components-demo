using System;

namespace TodoApp.Models.Abstracts
{
    public interface IAudiable
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}