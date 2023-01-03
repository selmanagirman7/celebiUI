using Microsoft.AspNetCore.Http;

namespace WebPanel.Models
{
    public class ProductAdd
    {
        public string ProductName { get; set; }
        public string ProductNameEng { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescriptionEng { get; set; }
        public IFormFile ImgPath { get; set; }
        public IFormFile ImgPath2 { get; set; }
        public IFormFile ImgPath3 { get; set; }
        public IFormFile ImgPath4 { get; set; }
        public string Metarial { get; set; }
        public string MetarialEng { get; set; }
        public string SeatAngle { get; set; }
        public string SeatAngleEng { get; set; }
        public string TotalWeight { get; set; }
        public string TotalWeightEng { get; set; }
        public string Dimensions { get; set; }
        public string DimensionsEng { get; set; }
        public string BoxSize { get; set; }
        public string BoxSizeEng { get; set; }
    }
}
