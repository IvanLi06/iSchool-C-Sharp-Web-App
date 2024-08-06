using System.Collections.Generic;

namespace ISchoolAppWebAppIvan.Models
{
    public class DegreeModel
    {
        public List<Undergraduate> undergraduate { get; set; }
        public List<Graduate> graduate { get; set; }
        public string pageTitle { get; set; }
    }

    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public Undergraduate()
        {
            concentrations = new List<string>();
        }
    }

    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public List<string> availableCertificates { get; set; }
        public Graduate()
        {
            concentrations = new List<string>();
            availableCertificates = new List<string>();
        }

    }
}