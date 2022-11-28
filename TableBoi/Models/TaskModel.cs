using System;
using System.ComponentModel.DataAnnotations;

namespace TableBoi.Models
{
    public class TaskModel
    {
        [Display(Name = "Номер")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Имя")]
        public string TaskName { get; set; }
        [Required]
        [Display(Name = "Текст задачи")]
        public string TaskDescription { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата создания")]
        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
    }
}
