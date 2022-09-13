using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Galery : IEntity
    {
        [Key]
        public int GaleryId { get; set; }
        public string PageTitle { get; set; }
        public string PageTitleEng { get; set; }
        public string ImagePath { get; set; }
        


    }
}
