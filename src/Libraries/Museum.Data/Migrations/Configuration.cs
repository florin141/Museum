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

            //AddOrUpdateMuseumTypes(context);

            //AddOrUpdateCountries(context);

            //AddOrUpdateCities(context);

            //AddOrUpdateFeatures(context);

            //AddOrUpdateMuseums(context);
        }

        private static void AddOrUpdateMuseums(MuseumObjectContext context)
        {
            

            #region Museums 

            context.Set<Museums>().AddOrUpdate(
                new Museums
                {
                    MuseumName = "Pablo Gargallo",
                    Description =
                        "Museo monográfico dedicado a la obra del escultor aragonés Pablo Gargallo. Contiene esculturas, dibujos, grabados y los cartones realizados a modo de patrones para formar algunas de sus esculturas, así como el Fondo de Documentación relativo al propio artista y a la escultura contemporánea.",
                    BuiltDate = DateTime.Parse("05/03/1997"),
                    BecomeMuseumDate = DateTime.Parse("05/06/2000"),
                    OpeningHour = 10,
                    ClosingHour = 21,
                    AnnualVisitorCount = 20000,
                    AdmissionCharge = 4,
                    AreaId = 3,
                    MuseumTypeId = 2,
                    Features = features1
                },
                new Museums
                {
                    MuseumName = "Museo de Zaragoza",
                    Description =
                        "El edificio fue proyectado con motivo de la Exposición Hispano - Francesa como Pabellón de las Artes. En este museo se encuentran las secciones de Antigüedad y Bellas Artes.",
                    BuiltDate = DateTime.Parse("15/12/1980"),
                    BecomeMuseumDate = DateTime.Parse("22/12/1995"),
                    OpeningHour = 10,
                    ClosingHour = 21,
                    AnnualVisitorCount = 50000,
                    AdmissionCharge = 10,
                    AreaId = 3,
                    MuseumTypeId = 2,
                    Features = features1.Concat(features2).ToList()
                },
                new Museums
                {
                    MuseumName = "Alma Mater Museum",
                    Description =
                        "Museo monográfico dedicado a la obra del escultor aragonés Pablo Gargallo. Contiene esculturas, dibujos, grabados y los cartones realizados a modo de patrones para formar algunas de sus esculturas, así como el Fondo de Documentación relativo al propio artista y a la escultura contemporánea.",
                    BuiltDate = DateTime.Parse("05/06/1997"),
                    BecomeMuseumDate = DateTime.Parse("05/02/2000"),
                    OpeningHour = 10,
                    ClosingHour = 21,
                    AnnualVisitorCount = 20000,
                    AdmissionCharge = 4,
                    AreaId = 3,
                    MuseumTypeId = 2,
                    Features = features3
                },
                new Museums
                {
                    MuseumName = "IAACC Pablo Serrano",
                    Description =
                        "El Instituto Aragonés de Arte y Cultura Contemporáneos Pablo Serrano, reabre sus puertas con unas instalaciones ampliadas y renovadas para convertirse en referente de la cultura contemporánea no sólo aragonesa sino también nacional e internacional, al tiempo que profundiza en la figura del escultor aragonés que le da nombre.",
                    BuiltDate = DateTime.Parse("05/04/1970"),
                    BecomeMuseumDate = DateTime.Parse("05/09/1990"),
                    OpeningHour = 10,
                    ClosingHour = 21,
                    AnnualVisitorCount = 50000,
                    AdmissionCharge = 0,
                    AreaId = 3,
                    MuseumTypeId = 2,
                    Features = features1.Concat(features2).Concat(features3).Concat(features4).Concat(features5).ToList()
                }
            );

            #endregion
        }

        private static void AddOrUpdateFeatures(MuseumObjectContext context)
        {
            #region Features

            context.Set<Feature>().AddOrUpdate(
                new Feature
                {
                    Name = "Free Admision",
                    Description =
                        "Those people with a registered disability can enjoy free access to the Museo. Should they need support during their visit, the person accompanying them will also be exempt from the admission fee.",
                },
                new Feature
                {
                    Name = "Lifts",
                    Description =
                        "Lifts in the Nouvel Building and Sabatini Building have visual numbering schemes and are marked in braille and relief, but do not have audio indicators. Lifts in the Sabatini Building have a greater capacity than those in the Nouvel Building. All lifts have panoramic views, which means there is no fully accessible alternative for people with vertigo.",
                },
                new Feature
                {
                    Name = "Seating",
                    Description =
                        "There are benches in the cloister area on Floors 1, 2 and 3 in the Sabatini Building and some of the exhibition rooms.",
                },
                new Feature
                {
                    Name = "Cloakroom and Lockers",
                    Description =
                        "In both entrances there is a cloakroom service. In the Sabatini Building they can be accessed by ramp. In the entrance to the Nouvel Building there are automatic lockers for wheelchair users. For large items, using the cloakroom located in the entrance to the Nouvel Building is recommended, though it does not have wheelchair access.",
                },
                new Feature
                {
                    Name = "Parking",
                    Description =
                        "Groups arriving in adapted vehicles have access to free parking in the Museo’s loading bay, with access from Calle Argumosa, on the corner with Calle Hospital. To avoid any inconvenience this service must be requested beforehand.",
                },
                new Feature
                {
                    Name = "Medical Assistance",
                    Description =
                        "If you require medical assistance during your visit, there is a first-aid kit located in the main gallery of the Sabatini Building, Floor 1",
                },
                new Feature
                {
                    Name = "Information Staff",
                    Description =
                        "The information staff are trained to advise you about the services, spaces and activities offered by the Museo.",
                },
                new Feature
                {
                    Name = "Floor Plans",
                    Description =
                        "In different connecting areas that join the buildings and access points to lifts general floor plans can be found. Maps of the Museo can also be acquired at the information points.",
                },
                new Feature
                {
                    Name = "Signage",
                    Description =
                        "Information and emergency signs use internationally recognised pictograms. If any sign is difficult to understand or identify, please ask a member of the information staff or send a suggestion.",
                },
                new Feature
                {
                    Name = "Doors",
                    Description =
                        "The doors that provide access to the different areas in the Museo have sufficient opening width. The majority are hinged and occasionally move into busy areas. They are normally operated by using a handle; however, some doors can be particularly heavy.",
                },
                new Feature
                {
                    Name = "Ramps",
                    Description =
                        "The majority of slopes in the exhibition rooms are equipped with ramps, although these are without handrails on either side or wide approach areas. The Protocol Room in the Sabatini Building and the Bóvedas Room are not wheelchair accessible.",
                },
                new Feature
                {
                    Name = "Disabled WCs",
                    Description = "Disabled WCs are located in the following areas"
                },
                new Feature
                {
                    Name = "Wheelchair Loans",
                    Description =
                        "These must be requested at the Information Points in the Sabatini and Nouvel Buildings. The request will be registered and the personal details of the applicant will be noted down, including their ID number, passport number, or similar.",
                },
                new Feature
                {
                    Name = "Desks",
                    Description =
                        "The different desks distributed around the Museo are generally between 1 and 1.10m high. These desks do not have adapted areas that allow wheelchair users or people of short stature to approach comfortably.",
                });

            #endregion
        }

        private static void AddOrUpdateCities(MuseumObjectContext context)
        {
            #region City

            context.Set<City>().AddOrUpdate(
                new City { Id = 1, CityName = "Zaragoza", MayorName = "Raul Gonzalez", RegionId = 1 });

            #endregion
        }

        private static void AddOrUpdateCountries(MuseumObjectContext context)
        {
            #region Country

            context.Set<Country>().AddOrUpdate(
                new Country
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
                },
                new Country
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
                },
                new Country
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
                });

            #endregion
        }

        private static void AddOrUpdateMuseumTypes(MuseumObjectContext context)
        {
            #region MuseumType

            context.Set<MuseumType>().AddOrUpdate(
                new MuseumType
                {
                    Id = 1,
                    Name = "Archaeology",
                    Description =
                        " They display archeological artifacts. They can be open-air museums or they can exhibit items in a building."
                },
                new MuseumType
                {
                    Id = 2,
                    Name = "Art",
                    Description =
                        " Also known as art galleries. They are spaces for showing art objects, most commonly visual art objects as paintings, sculpture, photography, illustrations, drawings, ceramics or metalwork. First publicly owned art museum in Europe was Amerbach-Cabinet in Basel (Now Kunstmuseum Basel)."
                },
                new MuseumType
                {
                    Id = 3,
                    Name = "Encyclopedic",
                    Description =
                        " They are usually large institutions and they offer visitors a wide variety of information on many themes, both local and global. They are not thematically defined nor specialized."
                },
                new MuseumType
                {
                    Id = 4,
                    Name = "Historic House",
                    Description =
                        " A house or a building turned into a museum for a variety of reasons, most commonly because the person that lived in it was important or something important happened in it. House is often equipped with furniture like it was in the time when it was used. Visitors of the house learn through guides that tell story of the house and its inhabitants."
                },
                new MuseumType
                {
                    Id = 5,
                    Name = "History",
                    Description =
                        " They collect objects and artifacts that tell a chronological story about particular locality. Objects that are collected could be documents, artifacts, archeological findings and other. They could be in a building, historic house or a historic site."
                },
                new MuseumType
                {
                    Id = 6,
                    Name = "Living history",
                    Description =
                        " Type of a museum in which historic events are performed by actors to immerse a viewer and show how certain events looked like or how some crafts were performed because there is no other way to see them now because they are obsolete."
                },
                new MuseumType
                {
                    Id = 7,
                    Name = "Maritime",
                    Description =
                        " Specialized museums for displaying maritime history, culture or archaeology. Primarily archaeological maritime museums exhibit artifacts and preserved shipwrecks recovered from bodies of water. Maritime history museums, show and educate the public about humanity's maritime past."
                },
                new MuseumType
                {
                    Id = 8,
                    Name = "Military and War",
                    Description =
                        " Museums specialized in military histories. Usually organized from a point of view of a one nation and conflicts in which that country has taken part. They collect and present weapons, uniforms, decorations, war technology and other objects."
                },
                new MuseumType
                {
                    Id = 9,
                    Name = "Mobile",
                    Description =
                        " Museums that have no specific strict place of exhibiting. They could be exhibited from a vehicle or they could move from museum to museum as guests. Also a name for a parts of exhibitions of a museum that are sent to another museum."
                },
                new MuseumType
                {
                    Id = 10,
                    Name = "Natural History",
                    Description =
                        " Usually display objects from nature like stuffed animals or pressed plants. They educate about natural history, dinosaurs, zoology, oceanography, anthropology, evolution, environmental issues, and more."
                },
                new MuseumType
                {
                    Id = 11,
                    Name = "Open-Air",
                    Description =
                        " Characteristic for exhibiting outdoors. Exhibitions consist of buildings that recreate architecture from the past. First opened in Scandinavia near the end of the 19th century."
                },
                new MuseumType
                {
                    Id = 12,
                    Name = "Pop-Up",
                    Description =
                        " Nontraditional museum institutions. Made to last short and often relying on visitors to provide museum objects and labels while professionals or institution only provide theme. With that is constructed shared historical authority."
                },
                new MuseumType
                {
                    Id = 13,
                    Name = "Science",
                    Description =
                        "Specialized for science and history of science. In the beginning they were static displays of objects but now they are made so the visitors can participate and that way better learn about different branches of science."
                });

            #endregion
        }
    }
}
