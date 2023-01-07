﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRentalsApp.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}