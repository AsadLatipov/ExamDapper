﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDapper.Domain.Entities
{
    public class Music : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SingerId { get; set; }
        public string Length { get; set; }
        public int PlasylistId { get; set; }
    }
}
