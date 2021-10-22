using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Model.Abstract
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }
    public abstract class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
