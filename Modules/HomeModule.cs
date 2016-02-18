using Nancy;
using System;
using System.Collections.Generic;

namespace NumberToStringNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Get["/"] = _ => View["index.cshtml"];
      // Post["/result"] = _ =>
      // {
      //   string month = Request.Form["month"];
      //   string date = Request.Form["date"];
      //   string year = Request.Form["year"];
      //
      //   WeekdayFinder day = new WeekdayFinder();
      //   return View["result.cshtml", day.DayFinder(month, date, year)];
      // };

    }
  }
}
