using Microsoft.AspNetCore.Http;

namespace KaradumanRafUI.Models
{
    public class SliderAdd
    {
        public IFormFile ImgPath { get; set; }
        public IFormFile ImgPath2 { get; set; }
        public IFormFile ImgPath3 { get; set; }
        public IFormFile ImgPath4 { get; set; }
        public IFormFile ImgPath5 { get; set; }
        public string SliderText { get; set; }
        public string SliderText2 { get; set; }
        public string SliderText3 { get; set; }
        public string SliderText4 { get; set; }
        public string SliderText5 { get; set; }
    }
}
