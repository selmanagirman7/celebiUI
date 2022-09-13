using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Corporate : IEntity
    {
        [Key]
        public int CorporateId { get; set; }
        public string Title { get; set; }
        public string TitleEng { get; set; }
        public string Desc { get; set; }
        public string DescEng { get; set; }
    }
}
