using System;
using System.Collections.Generic;
using System.Text;
using Museum.Core.Domain;

namespace Museum.Service.Tests.Stubs
{
    public static class FeatureStub
    {
        public static Feature Feature1 = new Feature
        {
            Id = 1,
            Name = "Free Admision",
            Description =
                "Those people with a registered disability can enjoy free access to the Museo. Should they need support during their visit, the person accompanying them will also be exempt from the admission fee.",
        };

        public static Feature Feature2 = new Feature
        {
            Id = 2,
            Name = "Seating",
            Description =
                "There are benches in the cloister area on Floors 1, 2 and 3 in the Sabatini Building and some of the exhibition rooms.",
        };

        public static Feature Feature3 = new Feature
        {
            Id = 3,
            Name = "Cloakroom and Lockers",
            Description =
                "In both entrances there is a cloakroom service. In the Sabatini Building they can be accessed by ramp. In the entrance to the Nouvel Building there are automatic lockers for wheelchair users. For large items, using the cloakroom located in the entrance to the Nouvel Building is recommended, though it does not have wheelchair access.",
        };

        public static Feature Feature4 = new Feature
        {
            Id = 4,
            Name = "Parking",
            Description =
                "Groups arriving in adapted vehicles have access to free parking in the Museo’s loading bay, with access from Calle Argumosa, on the corner with Calle Hospital. To avoid any inconvenience this service must be requested beforehand.",
        };

        public static Feature Feature5 = new Feature
        {
            Id = 5,
            Name = "Medical Assistance",
            Description =
                "If you require medical assistance during your visit, there is a first-aid kit located in the main gallery of the Sabatini Building, Floor 1",
        };

        public static Feature Feature6 = new Feature
        {
            Id = 6,
            Name = "Information Staff",
            Description =
                "The information staff are trained to advise you about the services, spaces and activities offered by the Museo.",
        };

        public static Feature Feature7 = new Feature
        {
            Id = 7,
            Name = "Floor Plans",
            Description =
                "In different connecting areas that join the buildings and access points to lifts general floor plans can be found. Maps of the Museo can also be acquired at the information points.",
        };

        public static Feature Feature8 = new Feature
        {
            Id = 8,
            Name = "Signage",
            Description =
                "Information and emergency signs use internationally recognised pictograms. If any sign is difficult to understand or identify, please ask a member of the information staff or send a suggestion.",
        };

        public static Feature Feature9 = new Feature
        {
            Id = 9,
            Name = "Doors",
            Description =
                "The doors that provide access to the different areas in the Museo have sufficient opening width. The majority are hinged and occasionally move into busy areas. They are normally operated by using a handle; however, some doors can be particularly heavy.",
        };

        public static Feature Feature10 = new Feature
        {
            Id = 10,
            Name = "Ramps",
            Description =
                "The majority of slopes in the exhibition rooms are equipped with ramps, although these are without handrails on either side or wide approach areas. The Protocol Room in the Sabatini Building and the Bóvedas Room are not wheelchair accessible.",
        };

        public static Feature Feature11 = new Feature
        {
            Id = 11,
            Name = "Disabled WCs",
            Description = "Disabled WCs are located in the following areas"
        };

         public static Feature Feature12 = new Feature
         {
             Id = 12,
             Name = "Desks",
             Description =
                 "The different desks distributed around the Museo are generally between 1 and 1.10m high. These desks do not have adapted areas that allow wheelchair users or people of short stature to approach comfortably.",
         };

         public static IEnumerable<Feature> GetFeatures = new List<Feature>(collection: new[]
         {
             Feature1,
             Feature2,
             Feature3,
             Feature4,
             Feature5,
             Feature6,
             Feature7,
             Feature8,
             Feature9,
             Feature10,
             Feature11,
             Feature12
         });
    }
}
