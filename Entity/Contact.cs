using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public  class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameEng { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyPhone2 { get; set; }
        public string ComponayMail { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyAdressEng { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNameEng { get; set; }
        public string CustomerMail { get; set; }
        public string Subject { get; set; }
        public string Massage { get; set; }
    }
}

