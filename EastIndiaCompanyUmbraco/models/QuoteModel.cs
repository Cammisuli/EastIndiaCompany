using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EastIndiaCompanyUmbraco.models
{
    public class QuoteModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}