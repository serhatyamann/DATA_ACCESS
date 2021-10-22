using EF_Code_First.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Model.Concrete
{
    public class Book : Base
    {
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Description { get; set; }
        public int AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public virtual Author Author { get; set; }
    }
}
