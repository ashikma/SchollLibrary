using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Author
    {
        string authorId;
        string authorFirstName;
        string authorLastName;
        string authorYear;
        int countryId;
        string authorPicture;

        public string AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        [Required(ErrorMessage = "You must enter Autor Last Name")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Last Name cannot be longer than 15 characters and less than 2")]
        [FirstLetterCapital(ErrorMessage = "First letter must be capital")]
        public string AuthorFirstName
        {
            get { return authorFirstName; }
            set { authorFirstName = value; }
        }
        public string AuthorLastName
        {
            get { return authorLastName; }
            set { authorLastName = value; }
        }

        [Required(ErrorMessage = "You must enter Autor Year")]
        public string AuthorYear
        {
            get { return authorYear; }
            set { authorYear = value; }
        }
        [Required(ErrorMessage = "You must enter Autor Country")]
        public int CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }
        [Required(ErrorMessage = "You must enter Autor Photo")]
        public string AuthorPicture
        {
            get { return authorPicture; }
            set { authorPicture = value; }
        }

    }
    
}
