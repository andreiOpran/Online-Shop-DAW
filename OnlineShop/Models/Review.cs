﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Review
    {

        [Key]
        public int ReviewId { get; set; }

        // rating-ul nu este obligatoriu; rating-ul apartine [1,5]
        public int? Rating { get; set; }

        // continutul review-ului nu este obligatoriu
        public string? Content { get; set; }

        public DateTime? CreatedDate { get; set; }

        // foreign key
        public int? ProductId { get; set; }
        // BLOCKED
        // public virtual Product? Product { get; set; }

        // foreign key
        public string? UserId { get; set; }
        // BLOCKED
        // public virtual ApplicationUser? User { get; set; }


        // TODO
        // validare pe serviciu (IValidatableObject)
        /*
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Rating.HasValue && (Rating < 1 || Rating > 5))
            {
                yield return new ValidationResult("Rating must be between 1 and 5.");
            }
            if(Content != null && Content.Length < 3)
            {
                yield return new ValidationResult("Content must be at least 10 characters long.");
            }
            if(Content != null && Content.Length > 1024)
            {
                yield return new ValidationResult("Content must be at most 1024 characters long.");
            }

            // "!" comunica compilatorului ca nu se va returna niciodata null
            yield return ValidationResult.Success!;
        }
        */
    }
}