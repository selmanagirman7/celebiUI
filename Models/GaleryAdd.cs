using Microsoft.AspNetCore.Http;

namespace WebPanel.Models
{
    public class GaleryAdd
    {
        public string PageTitle { get; set; }
        public string PageTitleEng { get; set; }
        public IFormFile ImagePath { get; set; }
    }
}
