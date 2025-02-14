﻿using System.ComponentModel.DataAnnotations;

namespace SigortamNet.MVC.ViewModels
{
    public class VisitorViewModel : BaseViewModel
    {
        [Display(Name = "Araç Plakanız")]
        public string LicensePlate { get; set; }
        [Display(Name = "T.C. Kimlik Numaranız")]
        public string IdentificationNumber { get; set; }
        [Display(Name = "Ruhsat Seri Kodu")]
        public string LicenseSerialCode { get; set; }
        [Display(Name = "Ruhsat Seri No")]
        public string LicenseSerialNo { get; set; }
    }
}
