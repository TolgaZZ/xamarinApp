using Plugin.Media.Abstractions;
using System;
using System.IO;
using Xamarin.Essentials;

namespace tolgaExamen.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adress { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Land { get; set; }
        public string TelofEmail { get; set; }
        public string Description { get; set; }
        public Xamarin.Essentials.Location Location { get; set; }
        public MediaFile Image { get; set; }
    }
}