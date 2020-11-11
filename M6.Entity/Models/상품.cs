using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M6.Entity.Models
{
    public class 상품
    {
     
        [Display(ShortName ="", Name ="", AutoGenerateField = false, Description ="", Order =0)]
        [Key]

        public int 상품번호 { get; set; }
        
    }
}
