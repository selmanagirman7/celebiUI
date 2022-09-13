using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Slider : IEntity
    {
        [Key]
        public int SliderId { get; set; }
        public string ImgPath { get; set; }  
        public string ImgPath2 { get; set; }  
        public string ImgPath3{ get; set; }  
        public string ImgPath4 { get; set; }  
        public string ImgPath5 { get; set; }
        public string  SliderText { get; set; }
        public string  EnSliderText { get; set; }
        public string  SliderText2 { get; set; }
        public string  EnSliderText2 { get; set; }
        public string  SliderText3 { get; set; }
        public string  EnSliderText3 { get; set; }
        public string  SliderText4 { get; set; }
        public string  EnSliderText4 { get; set; }
        public string  SliderText5 { get; set; }
        public string  EnSliderText5 { get; set; }
    }
}
