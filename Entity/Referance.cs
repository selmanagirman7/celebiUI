using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Referance : IEntity
    {
        [Key]
        public int ReferanceId { get; set; }
        public string ReferanceName { get; set; }
        public string ReferanceNameEng { get; set; }
        public string ImagePath { get; set; }



    }
}
