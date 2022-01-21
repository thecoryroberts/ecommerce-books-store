﻿using Books.Domain.Entities;
using BulkyBook.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Domain.ViewModels
{
    public class ShoppingCart
    {

        public Guid Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }


        [Range(1,1000, ErrorMessage="Please enter a valur between 1 and 1000")]
        public int Count { get; set; }

        public string? ApplicationUserId { get; set; }


        [ForeignKey("ApplicationUserId")]
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
