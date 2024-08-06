using ISchoolAppWebAppIvan.Models;
using ISchoolAppWebAppIvan.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace IschoolAppWebAppIvan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedAbout = await dr.getData("about/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);
            rtnResult.pageTitle = "About the ISchool";
            // send the data to the view
            return View(rtnResult);
        }

        public async Task<IActionResult> People()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedPeople = await dr.getData("people/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<PeopleModel>(loadedPeople);
            rtnResult.pageTitle = "Our People";
            // send the data to the view
            return View(rtnResult);
        }

        public async Task<IActionResult> Degrees()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedDegrees = await dr.getData("degrees/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<DegreeModel>(loadedDegrees);
            rtnResult.pageTitle = "Degrees in the iSchool";
            // send the data to the view
            return View(rtnResult);
        }

        public async Task<IActionResult> Minors()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedMinors = await dr.getData("minors/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<MinorModel>(loadedMinors);
            rtnResult.pageTitle = "Minors in the iSchool";
            // send the data to the view
            return View(rtnResult);
        }

        public async Task<IActionResult> Employment()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedEmployment = await dr.getData("employment/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedEmployment);
            rtnResult.pageTitle = "Employment";
            // send the data to the view
            return View(rtnResult);
        }

        public async Task<IActionResult> Course()
        {
            /*go get data 
            put the data in the model
            send this result to the view
            */
            DataRetrieval dr = new DataRetrieval();
            // await
            var loadedCourse = await dr.getData("course/");
            // we now have a string need to cast it to JSON
            // Console.Write(loadedAbout);
            var rtnResult = JsonConvert.DeserializeObject<MinorModel>(loadedCourse);
            rtnResult.pageTitle = "Minors in the iSchool";
            // send the data to the view
            return View(rtnResult);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}