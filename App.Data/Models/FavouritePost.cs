﻿using System;
using System.Collections.Generic;

namespace App.Data.Models
{
    public partial class FavouritePost
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
    }
}
