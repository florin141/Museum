using System.Collections.Generic;

namespace Museum.Data.Migrations
{
    using Museum.Core.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MuseumObjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MuseumObjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            AddOrUpdateCountries(context);

            AddOrUpdateCities(context);

            AddOrUpdateMuseumTypes(context);

            AddOrUpdateFeatures(context);

            AddOrUpdateMuseums(context);
        }

        private static void AddOrUpdateCountries(MuseumObjectContext context)
        {
            #region Country

            var country1 = new Country
            {
                Id = 1,
                Name = "Spain",
                Capital = "Madrid",
                Language = "Spanish",
                CountryCode = "ES",
                DialingCode = "+34",
                DrivingSide = DrivingSide.Right,
                Currency = "EUR",
                GDP = 1946000000000
            };

            var country2 = new Country
            {
                Id = 2,
                Name = "France",
                Capital = "Paris",
                Language = "French",
                CountryCode = "FR",
                DialingCode = "+33",
                DrivingSide = DrivingSide.Right,
                Currency = "EUR",
                GDP = 3081000000000
            };

            var country3 = new Country
            {
                Id = 3,
                Name = "United Kingdom",
                Capital = "London",
                Language = "English",
                CountryCode = "UK",
                DialingCode = "+44",
                DrivingSide = DrivingSide.Left,
                Currency = "GBP",
                GDP = 3128000000000
            };

            context.Set<Country>().AddOrUpdate(
                country1, country2, country3);
            context.SaveChanges();

            #endregion
        }

        private static void AddOrUpdateCities(MuseumObjectContext context)
        {
            #region City

            City city1 = new City
            {
                Id = 1,
                Name = "Madrid",
                Mayor = "Jose Luis Martinez-Almeida",
                Area = 604.3f,
                Population = 3223334,
                Rank = 1,
                Density = 5333,
                Website = "https://www.madrid.es",
                CountryId = 1
            };

            City city2 = new City
            {
                Id = 2,
                Name = "Barcelona",
                Mayor = "Ada Colau Ballano",
                Area = 101.4f,
                Population = 1620343,
                Rank = 2,
                Density = 15979,
                Website = "https://www.barcelona.es",
                CountryId = 1
            };

            City city3 = new City
            {
                Id = 3,
                Name = "Valencia",
                Mayor = "Joan Ribo i Canut",
                Area = 134.64f,
                Population = 791413,
                Rank = 3,
                Density = 5877,
                Website = "https://www.valencia.es",
                CountryId = 1
            };

            City city4 = new City
            {
                Id = 4,
                Name = "Seville",
                Mayor = "Juan Espadas",
                Area = 140f,
                Population = 688711,
                Rank = 4,
                Density = 4919,
                Website = "https://www.sevilla.es",
                CountryId = 1
            };

            City city5 = new City
            {
                Id = 5,
                Name = "Zaragoza",
                Mayor = "Jorge Azcon",
                Area = 973.78f,
                Population = 666880,
                Rank = 5,
                Density = 680,
                Website = "https://www.zaragoza.es",
                CountryId = 1
            };

            City city6 = new City
            {
                Id = 6,
                Name = "Paris",
                Mayor = "Anne Hidalgo",
                Area = 105.4f,
                Population = 2140526,
                Rank = 1,
                Density = 20308,
                Website = "https://www.paris.fr",
                CountryId = 2
            };

            City city7 = new City
            {
                Id = 7,
                Name = "Marseille",
                Mayor = "Jean-Claude Gaudin",
                Area = 240.62f,
                Population = 855393,
                Rank = 2,
                Density = 3554,
                Website = "https://www.marseille.fr",
                CountryId = 2
            };

            City city8 = new City
            {
                Id = 8,
                Name = "Lyon",
                Mayor = "Gerard Collomb",
                Area = 47.87f,
                Population = 513275,
                Rank = 3,
                Density = 10722,
                Website = "https://www.lyon.fr",
                CountryId = 2
            };

            City city9 = new City
            {
                Id = 9,
                Name = "Toulouse",
                Mayor = "Jean-Luc Moudenc",
                Area = 118.3f,
                Population = 458298,
                Rank = 4,
                Density = 3874,
                Website = "https://www.toulouse.fr",
                CountryId = 2
            };

            City city10 = new City
            {
                Id = 10,
                Name = "Nice",
                Mayor = "Christian Estrosi",
                Area = 71.92f,
                Population = 342295,
                Rank = 5,
                Density = 4759,
                Website = "https://www.nice.fr",
                CountryId = 2
            };

            City city11 = new City
            {
                Id = 11,
                Name = "London",
                Mayor = "Sadiq Khan",
                Area = 1572,
                Population = 8908081,
                Rank = 1,
                Density = 5666,
                Website = "https://www.london.uk",
                CountryId = 3
            };

            City city12 = new City
            {
                Id = 12,
                Name = "Manchester",
                Mayor = "Abid Latif Chohan",
                Area = 115.6f,
                Population = 547627,
                Rank = 2,
                Density = 4131,
                Website = "https://www.manchester.uk",
                CountryId = 3
            };

            City city13 = new City
            {
                Id = 13,
                Name = "Liverpool",
                Mayor = "Joe Anderson",
                Area = 111.8f,
                Population = 494814,
                Rank = 3,
                Density = 4425,
                Website = "https://www.liverpool.uk",
                CountryId = 3
            };

            City city14 = new City
            {
                Id = 14,
                Name = "Cambridge",
                Mayor = "Gerri Bird",
                Area = 40.7f,
                Population = 125758,
                Rank = 4,
                Density = 3089,
                Website = "https://www.cambridge.uk",
                CountryId = 3
            };

            City city15 = new City
            {
                Id = 15,
                Name = "Oxford",
                Mayor = "Cllr Colin Cook",
                Area = 45.59f,
                Population = 154600,
                Rank = 5,
                Density = 3391,
                Website = "https://www.oxford.uk",
                CountryId = 3
            };

            context.Set<City>().AddOrUpdate(city1, city2, city3, city4, city5, city6, city7, city8, city9, city10,
                city11, city12, city13, city14, city15);
            context.SaveChanges();

            #endregion
        }

        private static void AddOrUpdateMuseumTypes(MuseumObjectContext context)
        {
            #region MuseumType

            var mt1 = new MuseumType { Id = 1, Name = "Achitecture" };
            var mt2 = new MuseumType { Id = 2, Name = "Anthropology" };
            var mt3 = new MuseumType { Id = 3, Name = "Aquarium" };
            var mt4 = new MuseumType { Id = 4, Name = "Arboretum" };
            var mt5 = new MuseumType { Id = 5, Name = "Archaeology" };
            var mt6 = new MuseumType { Id = 6, Name = "Architecture" };
            var mt7 = new MuseumType { Id = 7, Name = "Archive" };
            var mt8 = new MuseumType { Id = 8, Name = "Art" };
            var mt9 = new MuseumType { Id = 9, Name = "Artistical" };
            var mt10 = new MuseumType { Id = 10, Name = "Automotive" };
            var mt11 = new MuseumType { Id = 11, Name = "Aviation" };
            var mt12 = new MuseumType { Id = 12, Name = "Biology" };
            var mt13 = new MuseumType { Id = 13, Name = "Botanical" };
            var mt14 = new MuseumType { Id = 14, Name = "Cemetery" };
            var mt15 = new MuseumType { Id = 15, Name = "Children's" };
            var mt16 = new MuseumType { Id = 16, Name = "Church" };
            var mt17 = new MuseumType { Id = 17, Name = "Communications" };
            var mt18 = new MuseumType { Id = 18, Name = "Craft" };
            var mt19 = new MuseumType { Id = 19, Name = "Culture" };
            var mt20 = new MuseumType { Id = 20, Name = "Design" };
            var mt21 = new MuseumType { Id = 21, Name = "Education" };
            var mt22 = new MuseumType { Id = 22, Name = "Ethnography" };
            var mt23 = new MuseumType { Id = 23, Name = "Family" };
            var mt24 = new MuseumType { Id = 24, Name = "Film/Photography" };
            var mt25 = new MuseumType { Id = 25, Name = "Food/Drink" };
            var mt26 = new MuseumType { Id = 26, Name = "General" };
            var mt27 = new MuseumType { Id = 27, Name = "Historic House/Site" };
            var mt28 = new MuseumType { Id = 28, Name = "Historical Society" };
            var mt29 = new MuseumType { Id = 29, Name = "History" };
            var mt30 = new MuseumType { Id = 30, Name = "Library" };
            var mt31 = new MuseumType { Id = 31, Name = "Maritime" };
            var mt32 = new MuseumType { Id = 32, Name = "Military" };
            var mt33 = new MuseumType { Id = 33, Name = "Music" };
            var mt34 = new MuseumType { Id = 34, Name = "Natural History" };
            var mt35 = new MuseumType { Id = 35, Name = "Nature Center" };
            var mt36 = new MuseumType { Id = 36, Name = "Open-air" };
            var mt37 = new MuseumType { Id = 37, Name = "Park" };
            var mt38 = new MuseumType { Id = 38, Name = "Planetarium" };
            var mt39 = new MuseumType { Id = 39, Name = "Religion" };
            var mt40 = new MuseumType { Id = 40, Name = "Science" };
            var mt41 = new MuseumType { Id = 41, Name = "Space" };
            var mt42 = new MuseumType { Id = 42, Name = "Specialized" };
            var mt43 = new MuseumType { Id = 43, Name = "Technology" };
            var mt44 = new MuseumType { Id = 44, Name = "Transport" };
            var mt45 = new MuseumType { Id = 45, Name = "University" };
            var mt46 = new MuseumType { Id = 46, Name = "War" };

            context.Set<MuseumType>().AddOrUpdate(
                mt1, mt2, mt3, mt4, mt5, mt6, mt7, mt8, mt9, mt10, mt11, mt12, mt13, mt14, mt15, mt16, mt17, mt18, mt19,
                mt20, mt21, mt22, mt23, mt24, mt25, mt26, mt27, mt28, mt29, mt30, mt31, mt32, mt33, mt34, mt35, mt36,
                mt37, mt38, mt39, mt40, mt41, mt42, mt43, mt44, mt45, mt46);

            context.SaveChanges();

            #endregion
        }

        private static void AddOrUpdateFeatures(MuseumObjectContext context)
        {
            #region Features

            context.Set<Feature>().AddOrUpdate(
                new Feature
                {
                    Id = 1,
                    Name = "Accessible"
                },
                new Feature
                {
                    Id = 2,
                    Name = "Lift"
                },
                new Feature
                {
                    Id = 3,
                    Name = "Free Wi-Fi"
                },
                new Feature
                {
                    Id = 4,
                    Name = "Cloakroom"
                },
                new Feature
                {
                    Id = 5,
                    Name = "Lockers"
                },
                new Feature
                {
                    Id = 6,
                    Name = "Parking",
                    Description =
                        "Groups arriving in adapted vehicles have access to free parking in the Museo’s loading bay, with access from Calle Argumosa, on the corner with Calle Hospital. To avoid any inconvenience this service must be requested beforehand.",
                },
                new Feature
                {
                    Id = 7,
                    Name = "Restaurant"
                },
                new Feature
                {
                    Id = 8,
                    Name = "Shop"
                },
                new Feature
                {
                    Id = 9,
                    Name = "Library"
                },
                new Feature
                {
                    Id = 10,
                    Name = "ATM"
                },
                new Feature
                {
                    Id = 11,
                    Name = "Medical Assistance"
                },
                new Feature
                {
                    Id = 12,
                    Name = "Information Staff",
                    Description =
                        "The information staff are trained to advise you about the services, spaces and activities offered by the Museo.",
                },
                new Feature
                {
                    Id = 13,
                    Name = "Floor Plans",
                    Description =
                        "In different connecting areas that join the buildings and access points to lifts general floor plans can be found. Maps of the Museo can also be acquired at the information points.",
                },
                new Feature
                {
                    Id = 14,
                    Name = "Signage",
                    Description =
                        "Information and emergency signs use internationally recognised pictograms. If any sign is difficult to understand or identify, please ask a member of the information staff or send a suggestion.",
                },
                new Feature
                {
                    Id = 15,
                    Name = "Doors",
                    Description =
                        "The doors that provide access to the different areas in the Museo have sufficient opening width. The majority are hinged and occasionally move into busy areas. They are normally operated by using a handle; however, some doors can be particularly heavy.",
                },
                new Feature
                {
                    Id = 16,
                    Name = "Ramps",
                    Description =
                        "The majority of slopes in the exhibition rooms are equipped with ramps, although these are without handrails on either side or wide approach areas. The Protocol Room in the Sabatini Building and the Bóvedas Room are not wheelchair accessible.",
                },
                new Feature
                {
                    Id = 17,
                    Name = "Disabled WCs",
                    Description = "Disabled WCs are located in the following areas"
                },
                new Feature
                {
                    Id = 18,
                    Name = "Wheelchair Loans",
                    Description =
                        "These must be requested at the Information Points in the Sabatini and Nouvel Buildings. The request will be registered and the personal details of the applicant will be noted down, including their ID number, passport number, or similar.",
                },
                new Feature
                {
                    Id = 19,
                    Name = "Desks",
                    Description =
                        "The different desks distributed around the Museo are generally between 1 and 1.10m high. These desks do not have adapted areas that allow wheelchair users or people of short stature to approach comfortably.",
                });

            context.SaveChanges();

            #endregion
        }

        private static void AddOrUpdateMuseums(MuseumObjectContext context)
        {
            #region Museums 

            context.Set<Museo>().AddOrUpdate(
                new Museo
                {
                    Id = 1,
                    Name = "Thyssen-Bornemisza Museum",
                    Description =
                        "The Thyssen-Bornemisza Museum offers visitors an overview of art from the 13th century to the late 20th century.",
                    PhoneNumber = "+34902760511",
                    Address = "Palacio de Villahermosa, Paseo del Prado 8",
                    EmailAddress = "mtb@museothyssen.org",
                    OpeningHour = 10,
                    ClosingHour = 19,
                    AdmissionCharge = 10,
                    Website = "http://www.museothyssen.org/",
                    AnnualVisitor = 10000,
                    BuiltDate = DateTime.Parse("30/01/1990"),
                    Rating = 1,
                    CityId = 1,
                    MuseumTypeId = 8,
                    Features = context.Set<Feature>().Where(f => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Contains(f.Id)).ToList()
                },
                new Museo
                {
                    Id = 2,
                    Name = "Museo Nacional del Prado",
                    Description =
                        "The building that today houses the Museo Nacional del Prado was designed by architect Juan de Villanueva in 1785. It was constructed to house the Natural History Cabinet, by orders of King Charles III.",
                    PhoneNumber = "+34902107077",
                    Address = "Paseo del Prado",
                    EmailAddress = "museo.nacional@museodelprado.es",
                    OpeningHour = 10,
                    ClosingHour = 20,
                    AdmissionCharge = 14,
                    Website = "http://www.museodelprado.es/",
                    AnnualVisitor = 15000,
                    BuiltDate = DateTime.Parse("15/05/1785"),
                    Rating = 5,
                    CityId = 1,
                    MuseumTypeId = 8,
                    Features = context.Set<Feature>().Where(f => new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Contains(f.Id)).ToList()
                },
                new Museo
                {
                    Id = 3,
                    Name = "Museo del Romanticismo",
                    Description =
                        "La visita al palacete del Museo del Romanticismo te transportará al siglo XIX. Descubre cómo era la vida cotidiana y las costumbres de la alta burguesía durante el Romanticismo, así como quienes fueron los principales protagonistas de este movimiento en España.",
                    PhoneNumber = "+34914481045",
                    Address = "Calle San Mateo, 13",
                    EmailAddress = "informacion.romanticismo@mcu.es",
                    OpeningHour = 9,
                    ClosingHour = 18,
                    AdmissionCharge = 3,
                    Website = "http://en.museoromanticismo.mcu.es/index.html",
                    AnnualVisitor = 5000,
                    BuiltDate = DateTime.Parse("30/01/1850"),
                    Rating = 1,
                    CityId = 1,
                    MuseumTypeId = 29,
                    Features = context.Set<Feature>().Where(f => new[] { 1 }.Contains(f.Id)).ToList()
                },
                new Museo
                {
                    Id = 4,
                    Name = "Museo de la Energia",
                    Description =
                        "La Fábrica de Luz. Museo de la Energía es un espacio de ocio divulgativo y cultural en Ponferrada, comarca del Bierzo, donde el carbón es el actor principal en todo su recorrido. El Museo está ubicado en la antigua central térmica de la Minero Siderúrgica de Ponferrada (MSP), la cual estuvo en funcionamiento entre 1920 y 1971.",
                    PhoneNumber = "987400800",
                    Address = "Avenida de la Libertad, 46, Ponferrada",
                    EmailAddress = "guias@ciuden.es",
                    OpeningHour = 10,
                    ClosingHour = 17,
                    AdmissionCharge = 10,
                    Website = "http://www.lafabricadeluz.org/",
                    AnnualVisitor = 55000,
                    BuiltDate = DateTime.Parse("30/01/1971"),
                    Rating = 1,
                    CityId = 1,
                    MuseumTypeId = 40,
                    Features = context.Set<Feature>().Where(f => new[] { 1, 2, 3, 4, 6, 7, 8, 9 }.Contains(f.Id)).ToList()
                },
                new Museo
                {
                    Id = 5,
                    Name = "Museo Canario de Meteoritos",
                    Description =
                        "Museo Canario de Meteoritos alberga y custodia la tercera colección de meteoritos auténticos más importante de España.",
                    PhoneNumber = "+34727761413",
                    Address = "Apdo. Correos 3. Agüimes ",
                    EmailAddress = "direccion@museocanariodemeteoritos.com",
                    OpeningHour = 10,
                    ClosingHour = 19,
                    AdmissionCharge = 10,
                    Website = "http://www.museocanariodemeteoritos.com/",
                    AnnualVisitor = 10000,
                    BuiltDate = DateTime.Parse("30/01/1990"),
                    Rating = 1,
                    CityId = 1,
                    MuseumTypeId = 1
                },
                new Museo
                {
                    Id = 6,
                    Name = "Museum of Fire and Firefighters",
                    Description =
                        "LaLa puesta en marcha de este museo permite mostrar al público la labor que realizan los Bomberos, los medios con que cuentan para realizar su trabajo y cómo estos medios han evolucionado.",
                    PhoneNumber = "+34976724262",
                    Address = "Calle Ramón y Cajal, 32",
                    EmailAddress = "museofuego@zaragoza.es",
                    OpeningHour = 10,
                    ClosingHour = 19,
                    AdmissionCharge = 10,
                    Website = "http://www.zaragoza.es/ciudad/bomberos/",
                    AnnualVisitor = 5000,
                    BuiltDate = DateTime.Parse("30/01/1971"),
                    Rating = 5,
                    CityId = 5,
                    MuseumTypeId = 10,
                    Features = context.Set<Feature>().Where(f => new[] { 1, 8 }.Contains(f.Id)).ToList()
                },
                new Museo
                {
                    Id = 7,
                    Name = "Escuela Museo de Origami Zaragoza",
                    Description =
                        "Unique museum in Europe dedicated to the art of origami.",
                    PhoneNumber = "+34876034569",
                    Address = "Plaza San Agustín, 2",
                    EmailAddress = "emoz@emoz.es",
                    OpeningHour = 10,
                    ClosingHour = 21,
                    AdmissionCharge = 3,
                    Website = "http://www.emoz.es/",
                    AnnualVisitor = 10000,
                    BuiltDate = DateTime.Parse("30/01/1990"),
                    Rating = 5,
                    CityId = 5,
                    MuseumTypeId = 8,
                    Features = context.Set<Feature>().Where(f => new[] { 1, 2, 3, 4, 5, 6, 7, 8 }.Contains(f.Id)).ToList()
                });

            #endregion
        }
    }
}
