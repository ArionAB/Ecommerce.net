﻿
using System;

namespace Ecommerce.DataLayer.DTOs.Baby
{
    public class ProductPictureDTO
    {
        public Guid PictureId { get; set; }
        
        public string FileName { get; set; }

        public string ContentType { get; set; }

        public string FilePath { get; set; }

    }
}
