using System;
using System.ComponentModel.DataAnnotations;

namespace HomeWork28._05
{
    public class Quote
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This prop can not be empty")]
        public string Text {get;set;}
        public string Author { get; set; }
        [Required(ErrorMessage = "This prop can not be empty")]
        public DateTime InsertDate {get;set;}
    }
}