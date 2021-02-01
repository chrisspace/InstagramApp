using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstagramApp.Models
{
    public enum DescriptionType
    {
        [Display(Name = "free")]
        Free,

        [Display(Name ="In a relationship")]
        InaRelationship,

        [Display(Name = "Complicated")]
        ItsComplicated
    }
}
