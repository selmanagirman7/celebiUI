using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class HomeAbout : IEntity
    {
        [Key]
        public int HomeAboutId { get; set; }
        public string Feature { get; set; }
        public string FeatureEng { get; set; }
        public string Feature2 { get; set; }
        public string Feature2Eng { get; set; }
        public string FeatureDesc { get; set; }
        public string FeatureDescEng { get; set; }
        public string FeatureDesc2 { get; set; }
        public string FeatureDesc2Eng { get; set; }
    }
}
