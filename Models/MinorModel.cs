using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ISchoolAppWebAppIvan.Models
{
    public class MinorModel
    {
        public List<UgMinors> ugminors { get; set; }
        public string pageTitle { get; set; }
        public string courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class UgMinors
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }
        public string note { get; set; }
        public UgMinors()
        {
            courses = new List<string>();
        }
    }
}
