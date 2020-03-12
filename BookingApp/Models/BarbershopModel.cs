using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class BarbershopModel
    {
        public string ImgPath { get; set; }
        public string Name { get; set; }

        public BarbershopModel(string ImgPath, string Name)
        {
            this.ImgPath = ImgPath;
            this.Name = Name;
        }
    }
}
