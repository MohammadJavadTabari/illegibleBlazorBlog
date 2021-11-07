﻿using illegible.Kernel.Enums;
using illegible.Shared.BaseDTO;
using System;

using System.ComponentModel.DataAnnotations;


namespace illegible.Shared.SharedDTO.BlogPost
{
    public class BlogPostDTO : BlogBaseDTO
    {
        [Required]
        
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        
        public string Summary { get; set; }
        public DateTime WriteTime { get; set; }
        [Required]
        
        public string PostContext { get; set; }

        [Url]
        public string PostImageUrl { get; set; }

        [Url]
        public string PostVideoUrl { get; set; }

        [Url]
        public string PostAttachedFileUrl { get; set; }

        //public AttachedLinkType AttachedLinkTypeEnum { get; set; }

        [Url]
        public string PostAttachedLinkUrl { get; set; }
    }
}