using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class OurService : IEntity
    {
        [Key]
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string TitleEng { get; set; }
        public string Feature { get; set; }
        public string FeatureEng { get; set; }
        public string FeatureDesc { get; set; }
        public string FeatureDescEng { get; set; }
        public string Desc { get; set; }
        public string DescEng { get; set; }
        public string FlatIcon { get; set; }

    }
}
