﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFood.Entity
{
    public class Mail
    {
        public int MailId { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}