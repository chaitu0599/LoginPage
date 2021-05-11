﻿using LoginPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.Data;
using System.IO;
using OfficeOpenXml;
using Microsoft.AspNetCore.Hosting;

namespace LoginPage.Controllers
{

    public class EmployeeController : Controller
    {
        db dbop = new db();
        getdb gtop = new getdb();
        List<Tasks> tasks = new List<Tasks>();
        Tasks tk = new Tasks();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";
            _webHostEnvironment = env;
        }
        public IActionResult Emplogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Emplogin([Bind] Emp_login emp)
        {
            int res = dbop.LoginCheck(emp);
            if (res == 1)
            {
                HttpContext.Session.SetString("username", emp.Username);
                HttpContext.Session.SetString("empid", emp.empid.ToString());
                TempData["msg"] = "Yes";
            }
            else
            {
                TempData["msg"] = "No";
            }
            return View();
        }
        public IActionResult empop()
        {
            Emp_login a = new Emp_login
            {
                Username = HttpContext.Session.GetString("username")
            };
            return View(a);
        }
        public IActionResult newe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult newe([Bind] Newemp n)
        {
            int res = dbop.RegisterCheck(n);
            if (res == 1)
            {
                TempData["msg"] = "Yes";
            }
            else
            {
                TempData["msg"] = "No";
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            FetchData(id);
            return View(tk);
        }
        [HttpPost]
        public IActionResult Edit([Bind] Taskadd ta, int id)
        {
            int x = dbop.taskadd(ta, id);
            if (x == 1)
                TempData["msg"] = "Yes";
            else
                TempData["msg"] = "No";
            return View();
        }
        public IActionResult Createtask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Createtask([Bind] Taskadd ta)
        {
            int x = dbop.taskadd(ta, HttpContext.Session.GetString("empid"));
            if (x == 1)
            {
                TempData["msg"] = "Yes";
            }
            else
            {
                TempData["msg"] = "No";
            }
            return View();
        }
        public IActionResult Leaveapplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Leaveapplication([Bind] Leaveapp la)
        {
            string folder="No document added";
            if (la.Doc != null)
            {
                folder = "documents/";
                folder += Guid.NewGuid().ToString() + la.Doc.FileName;
                string ServerFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
                la.Doc.CopyToAsync(new FileStream(ServerFolder,FileMode.Create));
            }
            int x = dbop.leaveapp(la, folder, HttpContext.Session.GetString("empid"));
            if (x == 1)
                TempData["msg"] = "Yes";
            else
                TempData["msg"] = "No";
            return View();
        }
        public IActionResult Viewtask()
        {
            FetchData();
            return View(tasks);
        }
        public IActionResult Delete(int id)
        {
            con.Open();
            com.Connection = con;
            var parameter = com.CreateParameter();
            parameter.Value = id;
            parameter.ParameterName = "@id";
            com.Parameters.Add(parameter);
            com.CommandText = "UPDATE Task1 SET Isactive='0' WHERE id=@id";
            com.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Viewtask");
        }
        public IActionResult Details(int id)
        {
            FetchData(id);
            return View(tk);
        }
        private void FetchData()
        {
            if (tasks.Count > 0)
            {
                tasks.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                var parameter = com.CreateParameter();
                parameter.Value = Int32.Parse(HttpContext.Session.GetString("empid"));
                parameter.ParameterName = "@empid";
                com.Parameters.Add(parameter);
                com.CommandText = "SELECT TOP (1000) [id],[Taskname],[Startdate],[Enddate],[Taskduration],[Teamname],[summary],[Taskdetails],[Riskdetails],[Risksolution] FROM [Login].[dbo].[Task1] WHERE [isactive]='1' AND empid=@empid";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    tasks.Add(new Tasks()
                    {
                        id = dr["id"].ToString()
                    ,
                        Taskname = dr["Taskname"].ToString()
                    ,
                        Startdate = dr["Startdate"].ToString()
                    ,
                        Enddate = dr["Enddate"].ToString()
                    ,
                        Duration = dr["Taskduration"].ToString()
                    ,
                        Teamname = dr["Teamname"].ToString()
                    ,
                        Taskdetails = dr["Taskdetails"].ToString()
                    ,
                        Summary = dr["summary"].ToString()
                    ,
                        Riskdetails = dr["Riskdetails"].ToString()
                    ,
                        Risksolution = dr["Risksolution"].ToString(),
                    });
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult ExporttoExcel()
        {
            DataSet ds = gtop.Getrecord(HttpContext.Session.GetString("empid"));
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("sheet1");
                worksheet.Cells.LoadFromDataTable(ds.Tables[0], true);
                package.Save();
            }
            stream.Position = 0;
            string excelname = $"Tasklist-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelname);
        }
        private void FetchData(int id)
        {
            try
            {
                con.Open();
                com.Connection = con;

                var parameter = com.CreateParameter();
                parameter.Value = id;
                parameter.ParameterName = "@id";
                com.Parameters.Add(parameter);

                com.CommandText = "Select [id],[Taskname],[StartDate],[Enddate],[Taskduration],[Teamname],[summary],[Taskdetails],[Riskdetails],[Risksolution] from Task1 where id = @id";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    tk = new Tasks()
                    {
                        id = dr["id"].ToString()
                    ,
                        Taskname = dr["Taskname"].ToString()
                    ,
                        Startdate = dr["Startdate"].ToString()
                    ,
                        Enddate = dr["Enddate"].ToString()
                    ,
                        Duration = dr["Taskduration"].ToString()
                    ,
                        Teamname = dr["Teamname"].ToString()
                    ,
                        Taskdetails = dr["Taskdetails"].ToString()
                    ,
                        Riskdetails = dr["Riskdetails"].ToString()
                    ,
                        Risksolution = dr["Risksolution"].ToString()
                    ,
                        Summary = dr["summary"].ToString(),
                    };
                }
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}