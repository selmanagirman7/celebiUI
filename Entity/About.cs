using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class About : IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutTitleEng { get; set; }
        public string AboutName { get; set; }
        public string AboutNameEng { get; set; }
        public string AboutDescription { get; set; }
        public string AboutDescriptionEng { get; set; }
        public string Value { get; set; }
        public string ValueEng { get; set; }
        public string Mission { get; set; }
        public string MissionEng { get; set; }
        public string  Vission { get; set; }
        public string  VissionEng { get; set; }

    }
}
