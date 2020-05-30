﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnsafMarket.WebApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public int StudentsCount { get; set; }

        public int ProfessorsCount { get; set; }

        public int AdvertisementsCount { get; set; }
    }
}