using Microsoft.AspNetCore.Mvc;
using VyshnaviPortfolio.Models;

namespace VyshnaviPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Education()
        {
            var education = new List<Education>
            {
                new Education { Course="B.Tech CSE (Data Science)", College="Dadi Institute of Engineering and Technology", YearOfPassing=2024, Grade=7.5 },
                new Education { Course="Class XII", College="Andhra Pradesh Board", YearOfPassing=2020, Grade=8.5 },
                new Education { Course="Class X", College="Andhra Pradesh Board", YearOfPassing=2018, Grade=9.7 }
            };
            return View(education);
        }

        public IActionResult Internships()
        {
            var internships = new List<Internship>
            {
                new Internship { Company="V Info Technologies", Duration="45 Days", Field="Back End Development" },
                new Internship { Company="Smart Bridge Educational Services", Duration="6 Months", Field="Data Analytics with Tableau" },
                new Internship { Company="Microsoft", Duration="3 Months", Field="Microsoft Azure Data Scientist Associate"},
                new Internship { Company="AICTE", Duration="3 Months", Field="Cyber Security (Palo Alto)"},
            };
            return View(internships);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project {
                    Title="Deep Fake Image Detection",
                    Description="Detects fake videos using CNN, LSTM, GANs, and Transfer Learning.",
                    Technologies=new List<string>{"CNN","LSTM","GANs","Transfer Learning"}
                },
                new Project {
                    Title="Eon Housing Solution System",
                    Description="Digitizes property transactions with ASP.NET MVC, SQL Server, and Web APIs.",
                    Technologies=new List<string>{"ASP.NET MVC","Entity Framework","SQL Server"}
                },
                new Project {
                    Title="eCommerce Website",
                    Description="Your one‑stop online store offering quality products, seamless shopping, and fast delivery.",
                    Technologies=new List<string>{"ASP.NET MVC","Entity Framework","SQL Server"}
                }
            };
            return View(projects);
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
            {
                new Skill { Name="Python" },
                new Skill { Name="SQL" },
                new Skill { Name="HTML, CSS" },
                new Skill { Name=".NET Core" },
                new Skill { Name="AICTE Cloud Architecture (AWS Academy)" }
            };
            return View(skills);
        }

        public IActionResult Contact() => View();
    }
}