using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WorldData.Models;
using WorldData;

namespace WorldData.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      // string model="";
      List<City> model = new List<City>();
      // City cityNames = City.GetAll();
      Console.WriteLine("got here at least!");

      try
      {
        model = City.GetAll();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      try
      {
        Console.WriteLine("Name is: " + model[1].GetName());
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 2: " + ex);
      }

      return View("Index", model);
    }

    // [HttpPost("/")]
    // public ActionResult Result()
    // {
    //   string keyword =  Request.Form["Word"];
    //   string sentence =  Request.Form["Sentence"];
    //   string model ="";
    //   if ((! string.IsNullOrEmpty(keyword) ) && (! string.IsNullOrEmpty(sentence)) )
    //   {
    //     model = "Your word '" + keyword + "' appeared in the sentence '" + sentence + "' " + RepeatCounter.Counter(keyword, RepeatCounter.ValidateSentence(sentence)) + " time(s).";
    //   }
    //   else
    //   {
    //     model = "Please enter a valid keyword and sentence.";
    //   }
    //   return View("Index", model);
    // }

  }
}
