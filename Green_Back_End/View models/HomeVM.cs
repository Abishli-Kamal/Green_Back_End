using Green_Back_End.Models;
using System.Collections.Generic;

namespace Green_Back_End.View_models
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<CardOne> CardOnes { get; set; }
        public About Abouts { get; set; }
        public List<Servis> Services { get; set; }

    }
}
