﻿using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDataTablesProject.Models {
    public class Product {


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string PartNbr { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [DataType("decimal(11,2)")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(30)]
        public string Unit { get; set; }

        [MaxLength(255)]
        public string Photopath { get; set; }

        [Required]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }


    }
}





//| Name       | Type    | Null | Len  | Unique | PK  | FK  | Def | Gen | Notes |
//| ----       | ----    | ---- | ---  | ------ | --- | --- | --- | --- | ----- |
//| Id         | Integer | No   | N/A  | Yes    | Yes | No  | No  | Yes | 1,1   |
//| PartNbr    | String  | No   | 30   | Yes    | No  | No  | No  | No  |       |//is everyone going to know what PartNbr means?  Should it be displayed?
//| Name       | String  | No   | 30   | No     | No  | No  | No  | No  |       |
//| Price      | Decimal | No   | 11,2 | No     | No  | No  | No  | No  |       |//is the US Dollars?
//| Unit       | String  | No   | 30   | No     | No  | No  | No  | No  |       |
//| PhotoPath  | String  | Yes  | 255  | No     | No  | No  | No  | No  |       |//The pics are not stored in the db, only the path to the image?  To network share? a Url?
//| VendorId   | Integer | No   | N/A  | No     | No  | Yes | No  | No  | FK to Vendor |//a FK constraint(use EF to enforce).  Refuse to save the Product if it is not assigned to a valid Vendor
