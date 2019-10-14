using System;
using System.Collections.Generic;
using System.Text;
using Museum.Core.Domain;

namespace Museum.Service.Tests.Stubs
{
    public static class MuseumTypeStub
    {
        public static MuseumType MuseumType1 = new MuseumType
        {
            Id = 1,
            Name = "Archaeology",
            Description =
                        "They display archeological artifacts. They can be open-air museums or they can exhibit items in a building."
        };

        public static MuseumType MuseumType2 = new MuseumType
        {
            Id = 2,
            Name = "Art",
            Description =
                "Also known as art galleries. They are spaces for showing art objects, most commonly visual art objects as paintings, sculpture, photography, illustrations, drawings, ceramics or metalwork. First publicly owned art museum in Europe was Amerbach-Cabinet in Basel (Now Kunstmuseum Basel)."
        };

        public static MuseumType MuseumType3 = new MuseumType
        {
            Id = 3,
            Name = "Encyclopedic",
            Description =
                "They are usually large institutions and they offer visitors a wide variety of information on many themes, both local and global. They are not thematically defined nor specialized."
        };

        public static MuseumType MuseumType4 = new MuseumType
        {
            Id = 4,
            Name = "Historic House",
            Description =
                "A house or a building turned into a museum for a variety of reasons, most commonly because the person that lived in it was important or something important happened in it. House is often equipped with furniture like it was in the time when it was used. Visitors of the house learn through guides that tell story of the house and its inhabitants."
        };

        public static MuseumType MuseumType5 = new MuseumType
        {
            Id = 5,
            Name = "History",
            Description =
                "They collect objects and artifacts that tell a chronological story about particular locality. Objects that are collected could be documents, artifacts, archeological findings and other. They could be in a building, historic house or a historic site."
        };

        public static MuseumType MuseumType6 = new MuseumType
        {
            Id = 6,
            Name = "Living history",
            Description =
                "Type of a museum in which historic events are performed by actors to immerse a viewer and show how certain events looked like or how some crafts were performed because there is no other way to see them now because they are obsolete."
        };

        public static MuseumType MuseumType7 = new MuseumType
        {
            Id = 7,
            Name = "Maritime",
            Description =
                "Specialized museums for displaying maritime history, culture or archaeology. Primarily archaeological maritime museums exhibit artifacts and preserved shipwrecks recovered from bodies of water. Maritime history museums, show and educate the public about humanity's maritime past."
        };

        public static MuseumType MuseumType8 = new MuseumType
        {
            Id = 8,
            Name = "Military and War",
            Description =
                "Museums specialized in military histories. Usually organized from a point of view of a one nation and conflicts in which that country has taken part. They collect and present weapons, uniforms, decorations, war technology and other objects."
        };

        public static MuseumType MuseumType9 = new MuseumType
        {
            Id = 9,
            Name = "Mobile",
            Description =
                "Museums that have no specific strict place of exhibiting. They could be exhibited from a vehicle or they could move from museum to museum as guests. Also a name for a parts of exhibitions of a museum that are sent to another museum."
        };

        public static MuseumType MuseumType10 = new MuseumType
        {
            Id = 10,
            Name = "Natural History",
            Description =
                "Usually display objects from nature like stuffed animals or pressed plants. They educate about natural history, dinosaurs, zoology, oceanography, anthropology, evolution, environmental issues, and more."
        };

        public static MuseumType MuseumType11 = new MuseumType
        {
            Id = 11,
            Name = "Open-Air",
            Description =
                "Characteristic for exhibiting outdoors. Exhibitions consist of buildings that recreate architecture from the past. First opened in Scandinavia near the end of the 19th century."
        };

        public static MuseumType MuseumType12 = new MuseumType
        {
            Id = 12,
            Name = "Pop-Up",
            Description =
                "Nontraditional museum institutions. Made to last short and often relying on visitors to provide museum objects and labels while professionals or institution only provide theme. With that is constructed shared historical authority."
        };

        public static MuseumType MuseumType13 = new MuseumType
        {
            Id = 13,
            Name = "Science",
            Description =
                "Specialized for science and history of science. In the beginning they were static displays of objects but now they are made so the visitors can participate and that way better learn about different branches of science."
        };

        public static IEnumerable<MuseumType> GetMuseumTypes = new List<MuseumType>(collection: new[]
        {
            MuseumType1,
            MuseumType2,
            MuseumType3,
            MuseumType4,
            MuseumType5,
            MuseumType6,
            MuseumType7,
            MuseumType8,
            MuseumType9,
            MuseumType10,
            MuseumType11,
            MuseumType12,
            MuseumType13
        });
    }
}
