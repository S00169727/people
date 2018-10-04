﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.Pages
{
    public class handlerdemoModel : PageModel
    {
        public string Message { get; set; } = "";

        public void OnGet()
        {
            Message = "HTTP request was a GET";
        }

        public void OnPost()
        {
            Message = "HTTP request was a POST";
        }
    }
}