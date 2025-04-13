using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
