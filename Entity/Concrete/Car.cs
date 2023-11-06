﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete
{
    public class Car : IEntitiy
    {
        public int Id{
            get;
            set;
        }
        public int BrandId {
            get;
            set;
        }


        public int ColorId { get; set; }

        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
