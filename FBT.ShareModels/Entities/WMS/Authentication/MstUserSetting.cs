﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBT.ShareModels.WMS
{
    public class MstUserSetting
    {
        [Key] public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Currency { get; set; } = "USD";
    }
}
