﻿using LoginPage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Session;
using RestSharp;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        empdb emdb = new empdb();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<employee> employees = new List<employee>();
        getdb gtop = new getdb();
        private readonly ILogger<HomeController> _logger;

        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";
        }
        
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            int res = dbop.LoginCheck(ad);
            if (res == 1)
            {
                HttpContext.Session.SetString("username", ad.Username);
                string xi = HttpContext.Session.GetString("username");
                TempData["user"] = xi;
                TempData["msg"] = "Yes";
            }
            else
            {
                TempData["msg"] = "No";
            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
        public IActionResult add()
        {
            Ad_login a = new Ad_login
            {
                Username = HttpContext.Session.GetString("username")
            };
            return View(a);
        }
        public IActionResult viewr()
        {
            DataSet ds = gtop.Getrecord();
            FetchData();
            return View(employees);
        }
        public IActionResult ExporttoExcel()
        {
            DataSet ds = gtop.Getrecord();
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("sheet1");
                worksheet.Cells.LoadFromDataTable(ds.Tables[0], true);
                package.Save();
            }
            stream.Position = 0;
            string excelname = $"EmployeeList-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelname);
        }
        private void FetchData()
        {
            if (employees.Count > 0) {
                employees.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [name],[dob],[father],[mother],[address],[salary],[fresher],[role],[notes] FROM [Login].[dbo].[employees]";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    employees.Add(new employee() {name=dr["name"].ToString()
                    ,dob=dr["dob"].ToString()
                    ,father=dr["father"].ToString()
                    ,mother=dr["mother"].ToString()
                    ,address=dr["address"].ToString()
                    ,salary=dr["salary"].ToString()
                    ,fresher=dr["fresher"].ToString()
                    ,role=dr["role"].ToString()
                    ,notes=dr["notes"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form([Bind] empadd em)
        {
            int x=emdb.Emp(em);
            if (x == 1)
            {
                TempData["msg"] = "Yes";
            }
            else
                TempData["msg"] = "No";
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
