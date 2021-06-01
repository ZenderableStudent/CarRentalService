using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CarRentalService.Infrastructure
{ //mamy dostep do Web.config, gdzie dodalismy  wlasny klucz o nazwie "AutaGrafika"
    //w przypadku braku klasy zwracajacej adresy obrazkow, dodajemy ja (w tym wypadku nazwana jest "UrlHelpers")
    public class AppConfig
    {
        private static string postersPath = ConfigurationManager.AppSettings["AutaGrafika"];

        public static string PostersPath { get => postersPath; set => postersPath = value; }
    }
}