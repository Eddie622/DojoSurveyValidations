using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DojoSurveyValidations.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Name :")]
        public string Name {get;set;}

        [Required]
        [Display(Name = "Dojo Location :")]
        public string Location {get;set;}
        public List<SelectListItem> Locations {get;} = new List<SelectListItem>
        {
            new SelectListItem { Value = "Arlington", Text = "Arlington"},
            new SelectListItem { Value = "Dallas", Text = "Dallas"},
            new SelectListItem { Value = "Chicago", Text = "Chicago"},
            new SelectListItem { Value = "Tulsa", Text = "Tulsa"}
        };

        [Required]
        [Display(Name = "Favorite Language :")]
        public string Language {get;set;}
        public List<SelectListItem> Languages {get;} = new List<SelectListItem>
        {
            new SelectListItem { Value = "C#", Text = "C#"},
            new SelectListItem { Value = "Python", Text = "Python"},
            new SelectListItem { Value = "Java", Text = "Java"},
            new SelectListItem { Value = "Ruby", Text = "Ruby"}
        };

        [MaxLength(20)]
        [Display(Name = "Comment :")]
        public string Comment {get;set;}
    }
}