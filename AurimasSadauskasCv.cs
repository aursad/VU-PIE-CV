using System;
using System.Collections.Generic;

namespace Vu.Pie
{
    public class BendraInformacija
    {
        public string VardasPavardė { get; set; }
        public DateTime GimimoData { get; set; }
        public string Elpaštas { get; set; }
    }

    public class Cv : BendraInformacija
    {
        public List<MokymosiVieta> Išsilavinimas { get; set; }
        public List<DarboVieta> DarboPatirtis { get; set; }
        public List<Kalba> Kalbos { get; set; }
        public List<string> Igūdžiai { get; set; }
        public List<string> Sugebėjimai { get; set; }
        public List<string> Tikslai { get; set; }
    }

    public class AurimasSadauskas
    {
        public void Cv()
        {
            var cv = new Cv
            {
                VardasPavardė = "Aurimas Sadauskas",
                GimimoData = new DateTime(1992, 1, 22),
                Elpaštas = "aurimas.sadauskas@gmail.com",
                Išsilavinimas = new List<MokymosiVieta>
                {
                    new MokymosiVieta
                    {
                        Metai = new DateTime(2007),
                        Tipas = MokymosiVietosTipas.Pagrindinis,
                        Pavadinimas = "Vilkyčių pagrindinė mokykla"
                    },
                    new MokymosiVieta
                    {
                        Metai = new DateTime(2011),
                        Tipas = MokymosiVietosTipas.Vidurinis,
                        Pavadinimas = "Šilutės Vydūno gimnazija"
                    },
                    new MokymosiVieta
                    {
                        Metai = DateTime.Now.Year,
                        Tipas = MokymosiVietosTipas.AukštasisUniversitetinis,
                        Pavadinimas = "Vilniaus Universitetas, programų sistemos"
                    }
                },
                DarboPatirtis = new List<DarboVieta>
                {
                    new DarboVieta
                    {
                        Nuo = new DateTime(2013,11,1), Iki = DateTime.Now,
                        Įmonė = "Visma Lietuva", Pareigos = ".NET programuotojas"
                    }
                },
                Kalbos = new List<Kalba> { Kalba.Anglų, Kalba.Rusų },
                Igūdžiai = new List<string> { "C#", ".NET", "SQL", "PHP", "Git", "Html", "Css", "Scrum", "Agile" },
                Sugebėjimai = new List<string>
                {
                    "Įtraukti komandą į darbą", "Valdyti komandą", "Noras tobulėti", 
                    "Užsibrėžtų tikslų siekimas", "Atsakingas požiūris į darbą"
                },
                Tikslai = new List<string> { "Darbas komandoje", "Komandos valdymas", "Tobulėjimas" }
            };
        }
    }

    public class MokymosiVieta
    {
        public DateTime Metai { get; set; }
        public MokymosiVietosTipas Tipas { get; set; }
        public string Pavadinimas { get; set; }
    }

    public class DarboVieta
    {
        public DateTime Nuo { get; set; }
        public DateTime Iki { get; set; }
        public string Įmonė { get; set; }
        public string Pareigos { get; set; }
    }

    public enum Kalba
    {
        Anglų,
        Rusų
    }

    public enum MokymosiVietosTipas
    {
        Pagrindinis,
        Vidurinis,
        AukštasisUniversitetinis
    }
}
