using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameEng { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionEng { get; set; }
        public string ImgPath { get; set; }
        public string Metarial { get; set; }
        public string MetarialEng { get; set; }
        public string SeatAngle { get; set; }
        public string SeatAngleEng { get; set; }
        public string TotalWeight { get; set; }
        public string TotalWeightEng{ get; set; }
        public string Dimensions { get; set; }
        public string DimensionsEng { get; set; }
        public string BoxSize { get; set; }
        public string BoxSizeEng { get; set; }
        public string ThumbDesc { get; set; }
        public string ThumbDescEng { get; set; }
    }

}
