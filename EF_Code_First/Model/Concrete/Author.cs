using EF_Code_First.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Model.Concrete
{
    public class Author : Base
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length is 300")]
        public string ShortBio { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
