using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Book
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public int BookId { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Name { get; set; }

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Genre { get; set; }

        [Display(Name = "Количество страниц")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public int PageNumber { get; set; }

        [Display(Name = "Номер Автора")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public int? FkAuthor { get; set; }

        public Author Author { get; set; }
    }
}
