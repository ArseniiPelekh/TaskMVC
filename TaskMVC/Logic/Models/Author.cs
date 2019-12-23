using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Data.Models
{
    public class Author
    {
        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public int AuthorId { get; set; }

        [Display(Name="Имя")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Surname { get; set; }

        [Display(Name = "Отчесвто")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string MiddleName { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public string Phone { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Пожалуйста, введите значение")]
        public DateTime Birthday { get; set; }

        [HiddenInput(DisplayValue = false)]
        public ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}
