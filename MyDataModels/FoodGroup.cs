﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataModels
{
    //public enum FoodGroupName
    //{
    //    Protein = 1,
    //    Produce = 2,
    //    [Display(Name = "Dry Goods")]
    //    DryGoods = 3,
    //    Liquids = 4
    //}

    public class FoodGroup
    {

        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Group { get; set; }

        public virtual List<Food> Foods { get; set; } = new List<Food>();

        //public override string ToString()
        //{
        //    return Group;
        //}
    }
}
