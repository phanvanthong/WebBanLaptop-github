﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanLaptop.Models;
using PagedList;
using PagedList.Mvc;

namespace WebBanLaptop.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        Web_ban_laptopEntities db = new Web_ban_laptopEntities();
        public ActionResult Index(int id=1,int page=1 )
        {   
            //int hangsx = (id ?? 1);
            //int pageNumber = (page ?? 1);
            int hangsx = id;
            int pageNumber = page;
            int pageSize = 12;
            if (hangsx>0 && hangsx<9)
            {
                return View(db.Products.Where(n => n.Hangsx_id == hangsx).ToList().OrderBy(n => n.Products_id).ToPagedList(pageNumber, pageSize));
            }
            else
            {
                Response.StatusCode = 404;
                return null;
            }
        }

        

    }
}