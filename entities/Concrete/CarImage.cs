﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int ID { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
    }
}
