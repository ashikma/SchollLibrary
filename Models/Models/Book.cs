using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public class Book
    {
        string bookId;
        string bookName;
        string bookDescription;
        string bookImage;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        [Required(ErrorMessage = "You must enter Book Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Book Name cannot be longer than 100 characters and less than 2")]
        [FirstLetterCapital(ErrorMessage = "First letter must be capital")]
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        [Required(ErrorMessage = "You must enter Book description")]
        public string BookDescription
        {
            get { return bookDescription; }
            set { bookDescription = value; }
        }

        [Required(ErrorMessage = "You must enter Book Picture")]
        public string BookImage
        {
            get { return bookImage; }
            set { bookImage = value; }
        }   

    }
}
