﻿using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;

namespace Volo.CmsKit.Pages
{
    public class CreatePageInputDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Url { get; set; }

        public string Description { get; set; }
    }
}