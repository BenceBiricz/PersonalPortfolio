using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioProject.Models;
using System.Diagnostics;

namespace PersonalPortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<PortfolioViewModel> _ports = new List<PortfolioViewModel>()
        {
            new PortfolioViewModel()
            {
                Id = 1,
                CardHeader = "ASP .NET",
                CardTitle  = "Personal Portfolio",
                ImgPath = "Images\\portfolio.png",
                CardText = "This website was created in ASP .NET Core, and showcases my skills.",
                GitHubLink = "https://github.com/BenceBiricz/PersonalPortfolio",
            },
            new PortfolioViewModel()
            {
                Id = 2,
                CardHeader = "VR",
                CardTitle  = "Motion Tracking",
                ImgPath = "Images\\vr.png",
                CardText = "Godot plugin to track the users motion and measure VR Jitter.",
                GitHubLink = "https://github.com/BenceBiricz/VR-movement-tracking",
            },
            new PortfolioViewModel()
            {
                Id = 3,
                CardHeader = "VR",
                CardTitle  = "Eye/Gaze Tracking",
                ImgPath = "Images\\eye.jpg",
                CardText = "Eye tracking and gaze tracking in virtual space. Images are in a python app.",
                GitHubLink = "https://github.com/BenceBiricz/VR_Eye_Gaze_Tracking",
            },
            new PortfolioViewModel()
            {
                Id = 4,
                CardHeader = "ASP .NET",
                CardTitle  = "Smart advisor",
                ImgPath = "Images\\phone.png",
                CardText = "Basic WEB application for impementing OpenAi API to a webpage.",
                GitHubLink = "https://github.com/BenceBiricz/SmartPhoneTechAdvisor",
            },
            new PortfolioViewModel()
            {
                Id = 5,
                CardHeader = "Unity",
                CardTitle  = "3D RPG Game Dev",
                ImgPath = "Images\\unity.png",
                CardText = "A 3D RPG game created in Unity called Hero's Journey.",
                GitHubLink = "https://github.com/BenceBiricz/3D_game_Unity",
            },
            new PortfolioViewModel()
            {
                Id = 6,
                CardHeader = "Python",
                CardTitle  = "Image Processing",
                ImgPath = "Images\\segmentation.png",
                CardText = "Segmentation of surgical devices on Synthetic MICCAI dataset.",
                GitHubLink = "https://github.com/BenceBiricz/Medical_Instrument_Segmentation",
            },
            new PortfolioViewModel()
            {
                Id = 7,
                CardHeader = "C#",
                CardTitle  = "Edge Detection",
                ImgPath = "Images\\sobel.jpg",
                CardText = "Sobel Edge detection algorithm created in C# with threading.",
                GitHubLink = "https://github.com/BenceBiricz/Sobel_Edge_Detection",
            },
            new PortfolioViewModel()
            {
                Id = 8,
                CardHeader = "C#",
                CardTitle  = "Emotion Detection",
                ImgPath = "Images\\emotion.png",
                CardText = "The task is to detect and recognise the emotions of the human face.",
                GitHubLink = "https://github.com/BenceBiricz/Emotion_Detection",
            }

        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(model:_ports);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}