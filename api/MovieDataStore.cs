
using System.Collections.Generic;
using api.Models;

namespace api{
   
    public class MovieDataStore {
        
        public static MovieDataStore Current {get;} = new MovieDataStore();
        public List<MovieDto> Movies {get; set;}
        public MovieDataStore(){
            Movies = new List<MovieDto>(){
                new MovieDto(){
                    Id = 1,
                    Name = "Marvella Vice",
                    Desc = "Mejor Puta Serie Ever, te extraño iris",
                    Casts = new List<CastDto>(){
                        new CastDto{Id = 1 , name = "Carola", Character = "Fedor Chernyshev" },
                        new CastDto{Id = 2 , name = "karchez", Character = "Greco Rodrigues"},
                        new CastDto{Id = 3 , name = "Elisa Waves", Character = "Iris marques"}
                    }
                },
                new MovieDto()
                {
                    Id = 2,
                    Name = "Mafia Italina",
                    Desc = "los locos de la mafia, vamos a llenar esta ciudad de mierda",
                    Casts = new List<CastDto>(){
                        new CastDto{Id = 1 , name = "Auron", Character = "Tony Gambino" },
                        new CastDto{Id = 2 , name = "Perxita", Character = "Carlo Gambino"},
                        new CastDto{Id = 3 , name = "Biyin", Character = "Ania Trostanova"}
                    }
                },
                new MovieDto()
                {
                    Id = 3,
                    Name = "Eliverse",
                    Desc = "Universo de la linea temporal creada por la todo poderosa elisa olas",
                    Casts = new List<CastDto>(){
                        new CastDto{Id = 1 , name = "Elisa Waves", Character = "Noah Sonchat" },
                        new CastDto{Id = 2 , name = "Elisa Waves", Character = "Agatha ONelli"},
                        new CastDto{Id = 3 , name = "Elisa Waves", Character = "Iris Marquez"}
                    }
                }
            };
        }
    }
}