using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class F1Team
    {
        public string TeamName { get; set; }
        public Pilot[] Pilots { get; set; }
        public int Wins { get; set; }

        public override string ToString()
        {
            return String.Format("Team {0}, Wins: {1}", TeamName, Wins);
        }
    }

    class Pilot
    {
        public F1Team Team { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IDCountry { get; set; }
        public int Points { get; set; }
    }

    class Country
    {
        public int IDCountry { get; set; }
        public string Name { get; set; }

        public static List<Country> All = new List<Country>(
            new Country[]
                 {
                    new Country(){IDCountry=1, Name="Spagna"},
                    new Country(){IDCountry=2, Name="Brasile"},
                    new Country(){IDCountry=3, Name="Germania"},
                    new Country(){IDCountry=4, Name="Australia"},
                    new Country(){IDCountry=5, Name="Regno Unito"},
                    new Country(){IDCountry=6, Name="Messico"},
                    new Country(){IDCountry=7, Name="Finlandia"},
                    new Country(){IDCountry=8, Name="Svizzera"},
                    new Country(){IDCountry=9, Name="Italia"},
                    new Country(){IDCountry=10, Name="USA"}
                 }
            );
    }


    class F1Data
    {
        public static List<F1Team> GetTeams()
        {
            List<F1Team> teams = new List<F1Team>();
            teams.Add(
                new F1Team() { TeamName = "Ferrari", Wins=7, Pilots = new Pilot[] 
                { 
                    new Pilot() { FirstName="Fernando", LastName="Alonso", IDCountry=1, Points=120 }, 
                    new Pilot() { FirstName="Felipe", LastName="Massa", IDCountry=2, Points=42 }
                } 
            });
            teams.Add(
                new F1Team()
                {
                    TeamName = "Red Bull", Wins=10, Pilots = new Pilot[2] 
                    {    
                        new Pilot() { FirstName="Sebastian", LastName="Vettel",IDCountry=3, Points=112 }, 
                        new Pilot() { FirstName="Mark", LastName="Webber", IDCountry=4, Points=77 }
                    }
                });

            teams.Add(
                new F1Team()
                {
                    TeamName = "McLaren", Wins=2,
                    Pilots = new Pilot[2] 
                    {    
                        new Pilot() { FirstName="Jenson", LastName="Button", IDCountry=5, Points=88 }, 
                        new Pilot() { FirstName="Sergio", LastName="Perez", IDCountry=6, Points=30 }
                    }
                });

            teams.Add(
                new F1Team()
                {
                    TeamName = "Lotus", Wins =3, 
                    Pilots = new Pilot[2] 
                    {    
                        new Pilot() { FirstName="Kimi", LastName="Raikkonen", IDCountry=7, Points=90 }, 
                        new Pilot() { FirstName="Romain", LastName="Grosjean", IDCountry=8, Points=51 }
                    }
                });

            teams.Add(
                new F1Team()
                {
                    TeamName = "Mercedes Petronas", Wins=1,
                    Pilots = new Pilot[2] 
                    {    
                        new Pilot() { FirstName="Nico", LastName="Rosberg", IDCountry=3, Points=63 }, 
                        new Pilot() { FirstName="Lewis", LastName="Hamilton", IDCountry=5, Points=98 }
                    }
                });

            return teams;
        }
    }
}
