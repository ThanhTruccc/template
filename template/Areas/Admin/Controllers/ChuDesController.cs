﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using template.Models;

namespace template.Areas.Admin.Controllers
{
    public class ChuDesController : Controller
    {
        QLBanSachEntity db = new QLBanSachEntity();
        private ADMIN _adm;
        // GET: Admin/ChuDe
        public ActionResult Index()
        {
            return View();
        }
    }
}