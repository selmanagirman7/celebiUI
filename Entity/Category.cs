using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Category : IEntity
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryNameEng { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryDescEng { get; set; }
        public string ImgPath { get; set; }



    }
}
