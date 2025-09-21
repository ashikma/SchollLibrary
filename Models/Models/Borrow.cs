using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels.Models
{
    public class Borrow
    {
        string borrowId;
        string readerId;
        string borrowDate;
        string borrowStatus;
        string bookId;

        public string BorrowId
        {
            get { return borrowId; }
            set { borrowId = value; }
        }
        public string ReaderId
        {
            get { return readerId; }
            set { readerId = value; }
        }

        [Required(ErrorMessage = "You must enter Borrow Date")] 
        [RegularExpression(@"^\d{2}\/\d{2}\/\d{4}$", ErrorMessage = "Date must be in format YYYY-MM-DD")]
        public string BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
        [RegularExpression(@"^\d{1}$", ErrorMessage = "Status must contain only digit")]  
        [Required(ErrorMessage = "You must enter Borrow Status")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Status cannot be longer than 15 characters and less than 2")]  
        public string BorrowStatus
        {
            get { return borrowStatus; }
            set { borrowStatus = value; }
        }
        [Required(ErrorMessage = "You must enter Book ID")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Status must contain only digit")]

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        

    }
}
