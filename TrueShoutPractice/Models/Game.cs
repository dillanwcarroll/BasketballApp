//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrueShoutPractice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Insert Date")]
        //[Required(ErrorMessage = "Enter the issued date.")]
        //[DisplayFormat(DataFormatString = "{0:d-MM-yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public System.DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Person Person { get; set; }

        //[Display(Name = "Insert Date")]
        //[Required(ErrorMessage = "Enter the issued date.")]
        //[DisplayFormat(DataFormatString = "{0:d-MM-yyyy HH:mm}", ApplyFormatInEditMode = false)]
        //public System.DateTime DateTime
        //{
        //    get
        //    {
        //        return DateTime.Now;
        //    }
        //    set
        //    {
        //        DateTime = DateTime.Now;
        //    }
        //}

    }
}