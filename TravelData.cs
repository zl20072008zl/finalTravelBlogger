using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace finalTravelBlogger
{
    class TravelData
    {
        public static List<Travel> visitedTravels { get; private set; }
        public static List<Travel> nextTravels { get; private set; }

        static TravelData()
        {
            var temp = new List<Travel>();

            AddVisitedCountry(temp);

            visitedTravels = temp.OrderBy(i => i.Country).ToList();

            temp = new List<Travel>();

            AddNextCountry(temp);

            nextTravels = temp.OrderBy(i => i.Country).ToList();
        }

        static void AddVisitedCountry(List<Travel> travels)
        {
            travels.Add(new Travel()
            {
                Country = "Canada",
                Blogger = "Canada is a North American country stretching from the U.S. in the south to the Arctic Circle in the north. Major cities include massive Toronto, west coast film centre Vancouver, French-speaking Montréal and Québec City, and capital city Ottawa. Canada's vast swaths of wilderness include lake-filled Banff National Park in the Rocky Mountains. It's also home to Niagara Falls, a famous group of massive waterfalls.",
                Image = Resource.Drawable.canada
            });
            travels.Add(new Travel()
            {
                Country = "USA",
                Blogger = "The U.S. is a country of 50 states covering a vast swath of North America, with Alaska in the northwest and Hawaii extending the nation’s presence into the Pacific Ocean. Major Atlantic Coast cities are New York, a global finance and culture center, and capital Washington, DC. Midwestern metropolis Chicago is known for influential architecture and on the west coast, Los Angeles' Hollywood is famed for filmmaking.",
                Image = Resource.Drawable.usa
            });
            travels.Add(new Travel()
            {
                Country = "China",
                Blogger = "China is a populous nation in East Asia whose vast landscape encompasses grassland, desert, mountains, lakes, rivers and more than 14,000km of coastline. Capital Beijing mixes modern architecture with historic sites such as the Forbidden City palace complex and Tiananmen Square. Shanghai is a skyscraper-studded global financial center. The iconic Great Wall of China runs east-west across the country's north.",
                Image = Resource.Drawable.china
            });
        }

        static void AddNextCountry(List<Travel> travels)
        {
            travels.Add(new Travel()
            {
                Country = "Brazil",
                Blogger = "Brazil, a vast South American country, stretches from the Amazon Basin in the north to vineyards and massive Iguaçu Falls in the south. Rio de Janeiro, symbolized by its 38m Christ the Redeemer statue atop Mount Corcovado, is famed for its busy Copacabana and Ipanema beaches as well as its enormous, raucous Carnaval festival, featuring parade floats, flamboyant costumes, and samba music and dance.",
                Image = Resource.Drawable.brazil
            });
            travels.Add(new Travel()
            {
                Country = "India",
                Blogger = "India is a vast South Asian country with diverse terrain – from Himalayan peaks to Indian Ocean coastline – and history reaching back 5 millennia. In the north, Mughal Empire landmarks include Delhi’s Red Fort complex and massive Jama Masjid mosque, plus Agra’s iconic Taj Mahal mausoleum. Pilgrims bathe in the Ganges in Varanasi, and Rishikesh is a yoga centre and base for Himalayan trekking.",
                Image = Resource.Drawable.india
            });
        }
    }
}