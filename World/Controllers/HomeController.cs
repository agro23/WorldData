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
      // Console.WriteLine("got here at least!");

      try
      {
        model = City.GetAll();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // try
      // {
      //   Console.WriteLine("Name is: " + model[1].GetName());
      // }
      // catch (Exception ex)
      // {
      //     Console.WriteLine("Exception 2: " + ex);
      // }

      // display cities by NAME, POPULATION
      // .OrderByDescending(x => x.Delivery.SubmissionDate);
      // .OrderByAscending(x => model.population);



      // Console.WriteLine(model[342].GetName());

      return View("City", model);
    }

    [HttpGet("/city-a")]
    public ActionResult CityAZ()
    {
      List<City> model = new List<City>();
      try
      {
          model = City.GetAll();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // Console.WriteLine(model[342].GetName());

      return View("City-a", model);
    }

    [HttpGet("/city-d")]
    public ActionResult CityZA()
    {
      List<City> model = new List<City>();
      try
      {
          model = City.GetAllDown();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // Console.WriteLine(model[342].GetName());

      return View("City-d", model);
    }

    [HttpGet("/population-a")]
    public ActionResult Pop09()
    {
      List<City> model = new List<City>();
      try
      {
          model = City.GetAllByPopUp();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // Console.WriteLine(model[342].GetName());

      return View("Population-a", model);
    }

    [HttpGet("/population-d")]
    public ActionResult Pop90()
    {
      List<City> model = new List<City>();
      try
      {
          model = City.GetAllByPopDown();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // Console.WriteLine(model[342].GetName());

      return View("Population-d", model);
    }





    [HttpGet("/country")]
    public ActionResult ShowCountry()
    {
      // string model="";
      List<Country> model = new List<Country>();
      // City cityNames = City.GetAll();
      // Console.WriteLine("got here at least!");

      try
      {
        model = Country.GetAll();
      }
      catch (Exception ex)
      {
          Console.WriteLine("Exception 1: " + ex);
      }

      // try
      // {
      //   Console.WriteLine("Name is: " + model[1].GetName());
      // }
      // catch (Exception ex)
      // {
      //     Console.WriteLine("Exception 2: " + ex);
      // }

      return View("Country", model);
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
