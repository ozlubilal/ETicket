﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class TownDto : IDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string TownName { get; set; }
    }
}
