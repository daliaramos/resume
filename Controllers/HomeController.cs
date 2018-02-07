using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Jobs.Models;

namespace Jobs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/addjob")]
    public ActionResult CreateJob()
    {
      Job newJob = new Job(
        Request.Form["job-title"],
        Request.Form["company-name"],
        Request.Form["location"],
        Request.Form["start-date"],
        Request.Form["end-date"],
        Request.Form["desc"]
      );
      return View("Confirmation", newJob);
    }
  }
}
