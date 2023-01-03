using Microsoft.AspNetCore.Http;

namespace KaradumanRafUI.Models
{
    public class ReferanceAdd
    {
        public string ReferanceName { get; set; }
        public string ReferanceNameEng { get; set; }
        public IFormFile ImagePath { get; set; }

    }

}
