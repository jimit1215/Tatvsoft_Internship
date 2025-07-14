﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Models
{
    public class MissionSkill
    {
        [Key]
        public int Id { get; set; }

        public string SkillName { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}
