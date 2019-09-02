using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDataTablesProject.Models {
    public class RequestLine {

        [Key]
        public int Id { get; set; }

        [Required]
        public Request RequestId { get; set; }

        [Required]
        public Product ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }














        //| Name            | Type    | Null | Len  | Unique | PK  | FK  | Def | Gen | Notes |//this is a relational table. Except for quantity.
        //| ----            | ----    | ---- | ---  | ------ | --- | --- | --- | --- | ----- |
        //| Id              | Integer | No   | N/A  | Yes    | Yes | No  | No  | Yes | 1,1   |
        //| RequestId       | Integer | No   | N/A  | No     | No  | Yes | No  | No  |       |//two links on the far right for the line "detail/edit", "lines" are used as button's on the web to add lines to the Request.
        //| ProductId       | Integer | No   | N/A  | No     | No  | Yes | No  | No  |       |
        //| Quantity        | Integer | No   | N/A  | No     | No  | No  | Yes | No  | def to 1 |//Text box which allows them to enter.



    }
}
