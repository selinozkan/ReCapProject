﻿using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concerete
{
   public  class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}