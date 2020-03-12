using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class CinemaModel
    {
        public string ImgPath { get; set; }
        public string Name { get; set; }

        public CinemaModel(string ImgPath, string Name)
        {
            this.ImgPath = ImgPath;
            this.Name = Name;
        }
    }
}
